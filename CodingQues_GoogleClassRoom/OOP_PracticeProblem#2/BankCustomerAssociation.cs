namespace CalculatorProblems;

public class AssocAccount
{
    public string AccountNumber { get; set; }
    public double Balance { get; set; }

    public AssocAccount(string accountNumber, double initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }
}

public class AssocBank
{
    public string BankName { get; set; }

    public AssocBank(string bankName)
    {
        BankName = bankName;
    }

    public AssocAccount OpenAccount(AssocCustomer customer, string accNo, double initialDeposit)
    {
        AssocAccount acc = new AssocAccount(accNo, initialDeposit);
        customer.Accounts.Add(acc);
        Console.WriteLine($"Account {accNo} opened for {customer.Name} at {BankName}.");
        return acc;
    }
}

public class AssocCustomer
{
    public string Name { get; set; }
    public List<AssocAccount> Accounts { get; set; }

    public AssocCustomer(string name)
    {
        Name = name;
        Accounts = new List<AssocAccount>();
    }

    public void ViewBalance()
    {
        Console.WriteLine($"--- Accounts for {Name} ---");
        foreach (var acc in Accounts)
        {
            Console.WriteLine($"Account No: {acc.AccountNumber}, Balance: {acc.Balance:C}");
        }
    }
}

public class BankCustomerAssociation
{
    public static void Run()
    {
        AssocBank bank = new AssocBank("National Bank");
        AssocCustomer customer = new AssocCustomer("Alice Smith");

        bank.OpenAccount(customer, "ACC1001", 1500.00);
        bank.OpenAccount(customer, "ACC1002", 3000.50);

        Console.WriteLine();
        customer.ViewBalance();
    }
}
