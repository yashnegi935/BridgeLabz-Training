namespace CalculatorProblems;

public class HierBankAccount
{
    public string AccountNumber { get; set; }
    public double Balance { get; set; }

    public HierBankAccount(string accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public virtual void DisplayAccountType()
    {
        Console.WriteLine($"Base Bank Account: {AccountNumber}, Balance: {Balance:C}");
    }
}

public class HierSavingsAccount : HierBankAccount
{
    public double InterestRate { get; set; }

    public HierSavingsAccount(string accountNumber, double balance, double interestRate)
        : base(accountNumber, balance)
    {
        InterestRate = interestRate;
    }

    public override void DisplayAccountType()
    {
        Console.WriteLine($"Savings Account [{AccountNumber}] - Balance: {Balance:C}, Interest Rate: {InterestRate}%");
    }
}

public class HierCheckingAccount : HierBankAccount
{
    public double WithdrawalLimit { get; set; }

    public HierCheckingAccount(string accountNumber, double balance, double withdrawalLimit)
        : base(accountNumber, balance)
    {
        WithdrawalLimit = withdrawalLimit;
    }

    public override void DisplayAccountType()
    {
        Console.WriteLine($"Checking Account [{AccountNumber}] - Balance: {Balance:C}, Daily Withdrawal Limit: {WithdrawalLimit:C}");
    }
}

public class HierFixedDepositAccount : HierBankAccount
{
    public int MaturityPeriodMonths { get; set; }

    public HierFixedDepositAccount(string accountNumber, double balance, int maturityPeriodMonths)
        : base(accountNumber, balance)
    {
        MaturityPeriodMonths = maturityPeriodMonths;
    }

    public override void DisplayAccountType()
    {
        Console.WriteLine($"Fixed Deposit Account [{AccountNumber}] - Balance: {Balance:C}, Lock-in Period: {MaturityPeriodMonths} months");
    }
}

public class BankAccountHierarchical
{
    public static void Run()
    {
        Console.WriteLine("--- Hierarchical Inheritance: Bank Accounts ---");

        List<HierBankAccount> accounts = new List<HierBankAccount>
        {
            new HierSavingsAccount("SA-101", 5000, 4.0),
            new HierCheckingAccount("CA-202", 12000, 2000),
            new HierFixedDepositAccount("FD-303", 25000, 12)
        };

        foreach (var acc in accounts)
        {
            acc.DisplayAccountType();
        }
    }
}
