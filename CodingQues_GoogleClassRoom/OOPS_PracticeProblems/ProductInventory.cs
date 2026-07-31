namespace CalculatorProblems;

public class Product
{
    public string ProductName { get; set; }
    public double Price { get; set; }
    public static int TotalProducts { get; private set; } = 0;

    public Product(string productName, double price)
    {
        ProductName = productName;
        Price = price;
        TotalProducts++;
    }

    public void DisplayProductDetails()
    {
        Console.WriteLine($"Product: {ProductName}, Price: {Price}");
    }

    public static void DisplayTotalProducts()
    {
        Console.WriteLine($"Total Products Created: {TotalProducts}");
    }
}

public class ProductInventory
{
    public static void Run()
    {
        Console.WriteLine("--- Product Inventory ---");

        Product p1 = new Product("Laptop", 1200.50);
        Product p2 = new Product("Mouse", 25.00);
        Product p3 = new Product("Keyboard", 45.00);

        p1.DisplayProductDetails();
        p2.DisplayProductDetails();
        p3.DisplayProductDetails();

        Console.WriteLine();
        Product.DisplayTotalProducts();
    }
}
