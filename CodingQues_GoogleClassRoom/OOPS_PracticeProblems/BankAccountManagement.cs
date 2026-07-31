namespace CalculatorProblems;

public class BankAccount
{
    public string AccountNumber;
    protected string AccountHolder;
    private double balance;

    public BankAccount(string accountNumber, string accountHolder, double initialBalance)
    {
        AccountNumber = accountNumber;
        AccountHolder = accountHolder;
        balance = initialBalance;
    }

    public double GetBalance()
    {
        return balance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited {amount:C}. New Balance: {balance:C}");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrew {amount:C}. Remaining Balance: {balance:C}");
        }
        else
        {
            Console.WriteLine("Insufficient funds or invalid amount.");
        }
    }
}

public class SavingsAccount : BankAccount
{
    public double InterestRate { get; set; }

    public SavingsAccount(string accountNumber, string accountHolder, double initialBalance, double interestRate)
        : base(accountNumber, accountHolder, initialBalance)
    {
        InterestRate = interestRate;
    }

    public void DisplayAccountSummary()
    {
        Console.WriteLine($"Account Number (Public): {AccountNumber}");
        Console.WriteLine($"Account Holder (Protected): {AccountHolder}");
        Console.WriteLine($"Current Balance (Private via Getter): {GetBalance():C}");
        Console.WriteLine($"Interest Rate: {InterestRate}%");
    }
}

public class BankAccountManagement
{
    public static void Run()
    {
        Console.WriteLine("--- Bank Account Management ---");

        SavingsAccount savings = new SavingsAccount("SA-109283", "Sarah Connor", 5000.00, 3.5);
        savings.DisplayAccountSummary();

        Console.WriteLine("\nExecuting Transactions...");
        savings.Deposit(1500.00);
        savings.Withdraw(2000.00);

        Console.WriteLine("\nFinal Summary:");
        savings.DisplayAccountSummary();
    }
}
