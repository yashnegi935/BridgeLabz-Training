namespace CalculatorProblems;

public interface ILoanable
{
    bool CalculateLoanEligibility();
    void ApplyForLoan(double amount);
}

public abstract class AbsBankAccount
{
    private string accountNumber;
    private string holderName;
    private double balance;

    public string AccountNumber
    {
        get { return accountNumber; }
    }

    public string HolderName
    {
        get { return holderName; }
    }

    public double Balance
    {
        get { return balance; }
        protected set { balance = value; }
    }

    public AbsBankAccount(string accountNumber, string holderName, double initialBalance)
    {
        this.accountNumber = accountNumber;
        this.holderName = holderName;
        this.balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"[{AccountNumber}] Deposited: {amount:C}. New Balance: {balance:C}");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"[{AccountNumber}] Withdrew: {amount:C}. Remaining Balance: {balance:C}");
        }
        else
        {
            Console.WriteLine($"[{AccountNumber}] Transaction declined.");
        }
    }

    public abstract double CalculateInterest();
}

public class AbsSavingsAccount : AbsBankAccount, ILoanable
{
    public double InterestRate { get; set; }

    public AbsSavingsAccount(string accountNumber, string holderName, double balance, double interestRate)
        : base(accountNumber, holderName, balance)
    {
        InterestRate = interestRate;
    }

    public override double CalculateInterest()
    {
        return Balance * (InterestRate / 100);
    }

    public bool CalculateLoanEligibility()
    {
        return Balance >= 5000.0;
    }

    public void ApplyForLoan(double amount)
    {
        if (CalculateLoanEligibility())
        {
            Console.WriteLine($"Savings Account [{AccountNumber}] approved for loan request of {amount:C}.");
        }
        else
        {
            Console.WriteLine($"Savings Account [{AccountNumber}] not eligible for loan.");
        }
    }
}

public class AbsCurrentAccount : AbsBankAccount
{
    public double OverdraftLimit { get; set; }

    public AbsCurrentAccount(string accountNumber, string holderName, double balance, double overdraftLimit)
        : base(accountNumber, holderName, balance)
    {
        OverdraftLimit = overdraftLimit;
    }

    public override double CalculateInterest()
    {
        return 0.0;
    }
}

public class BankingSystemAbstract
{
    public static void Run()
    {
        Console.WriteLine("--- Banking System ---");

        List<AbsBankAccount> accounts = new List<AbsBankAccount>
        {
            new AbsSavingsAccount("SAV-101", "David Miller", 6500.00, 4.5),
            new AbsCurrentAccount("CUR-202", "Tech Corp", 15000.00, 5000.00)
        };

        foreach (var acc in accounts)
        {
            Console.WriteLine($"Account: {acc.AccountNumber} | Holder: {acc.HolderName} | Balance: {acc.Balance:C} | Annual Interest: {acc.CalculateInterest():C}");
            if (acc is ILoanable loanable)
            {
                loanable.ApplyForLoan(10000.00);
            }
        }
    }
}
