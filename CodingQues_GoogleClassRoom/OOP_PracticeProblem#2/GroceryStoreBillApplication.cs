namespace CalculatorProblems;

public class GroceryProduct
{
    public string Name { get; set; }
    public double Quantity { get; set; }
    public double UnitPrice { get; set; }

    public GroceryProduct(string name, double quantity, double unitPrice)
    {
        Name = name;
        Quantity = quantity;
        UnitPrice = unitPrice;
    }

    public double GetTotalPrice()
    {
        return Quantity * UnitPrice;
    }
}

public class GroceryCustomer
{
    public string Name { get; set; }
    public List<GroceryProduct> PurchasedProducts { get; set; }

    public GroceryCustomer(string name)
    {
        Name = name;
        PurchasedProducts = new List<GroceryProduct>();
    }

    public void PurchaseProduct(string name, double quantity, double unitPrice)
    {
        PurchasedProducts.Add(new GroceryProduct(name, quantity, unitPrice));
    }
}

public class BillGenerator
{
    public double CalculateTotal(GroceryCustomer customer)
    {
        double total = 0;
        foreach (var product in customer.PurchasedProducts)
        {
            total += product.GetTotalPrice();
        }
        return total;
    }

    public void GenerateBill(GroceryCustomer customer)
    {
        Console.WriteLine($"=== Grocery Store Bill for {customer.Name} ===");
        foreach (var p in customer.PurchasedProducts)
        {
            Console.WriteLine($"{p.Name} ({p.Quantity} x ${p.UnitPrice}): ${p.GetTotalPrice():F2}");
        }
        Console.WriteLine($"Total Bill Amount: ${CalculateTotal(customer):F2}");
    }
}

public class GroceryStoreBillApplication
{
    public static void Run()
    {
        GroceryCustomer customer = new GroceryCustomer("Alice");

        customer.PurchaseProduct("Apples", 2, 3.00);
        customer.PurchaseProduct("Milk", 1, 2.00);

        BillGenerator generator = new BillGenerator();
        generator.GenerateBill(customer);
    }
}
