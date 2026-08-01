namespace CalculatorProblems;

public class EcomProduct
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public EcomProduct(int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
}

public class EcomOrder
{
    public int OrderId { get; set; }
    public List<EcomProduct> Products { get; set; }

    public EcomOrder(int orderId)
    {
        OrderId = orderId;
        Products = new List<EcomProduct>();
    }

    public void AddProduct(EcomProduct product)
    {
        Products.Add(product);
    }

    public double CalculateTotal()
    {
        double total = 0;
        foreach (var p in Products)
        {
            total += p.Price;
        }
        return total;
    }

    public void DisplayOrderSummary()
    {
        Console.WriteLine($"Order ID: {OrderId}");
        foreach (var p in Products)
        {
            Console.WriteLine($"- {p.Name}: {p.Price:C}");
        }
        Console.WriteLine($"Total Amount: {CalculateTotal():C}");
    }
}

public class EcomCustomer
{
    public int CustomerId { get; set; }
    public string Name { get; set; }
    public List<EcomOrder> Orders { get; set; }

    public EcomCustomer(int customerId, string name)
    {
        CustomerId = customerId;
        Name = name;
        Orders = new List<EcomOrder>();
    }

    public EcomOrder PlaceOrder(int orderId, List<EcomProduct> products)
    {
        EcomOrder order = new EcomOrder(orderId);
        foreach (var p in products)
        {
            order.AddProduct(p);
        }
        Orders.Add(order);
        Console.WriteLine($"Customer {Name} placed order #{orderId}.");
        return order;
    }
}

public class EcommercePlatform
{
    public static void Run()
    {
        EcomProduct p1 = new EcomProduct(1, "Wireless Mouse", 29.99);
        EcomProduct p2 = new EcomProduct(2, "Mechanical Keyboard", 89.99);
        EcomProduct p3 = new EcomProduct(3, "HD Monitor", 199.50);

        EcomCustomer customer = new EcomCustomer(1001, "Robert Downey");

        List<EcomProduct> cart1 = new List<EcomProduct> { p1, p2 };
        EcomOrder order1 = customer.PlaceOrder(5001, cart1);

        Console.WriteLine();
        order1.DisplayOrderSummary();
    }
}
