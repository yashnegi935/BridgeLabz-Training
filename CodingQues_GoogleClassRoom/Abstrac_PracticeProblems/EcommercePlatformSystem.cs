namespace CalculatorProblems;

public interface ITaxable
{
    double CalculateTax();
    string GetTaxDetails();
}

public abstract class AbsProduct
{
    private int productId;
    private string name;
    private double price;

    public int ProductId
    {
        get { return productId; }
        protected set { productId = value; }
    }

    public string Name
    {
        get { return name; }
        protected set { name = value; }
    }

    public double Price
    {
        get { return price; }
        protected set { price = value; }
    }

    public AbsProduct(int productId, string name, double price)
    {
        this.productId = productId;
        this.name = name;
        this.price = price;
    }

    public void UpdatePrice(double newPrice)
    {
        if (newPrice >= 0)
        {
            price = newPrice;
        }
    }

    public abstract double CalculateDiscount();
}

public class AbsElectronics : AbsProduct, ITaxable
{
    public AbsElectronics(int productId, string name, double price)
        : base(productId, name, price)
    {
    }

    public override double CalculateDiscount()
    {
        return Price * 0.10;
    }

    public double CalculateTax()
    {
        return Price * 0.18;
    }

    public string GetTaxDetails()
    {
        return "18% Electronics GST";
    }
}

public class AbsClothing : AbsProduct, ITaxable
{
    public AbsClothing(int productId, string name, double price)
        : base(productId, name, price)
    {
    }

    public override double CalculateDiscount()
    {
        return Price * 0.15;
    }

    public double CalculateTax()
    {
        return Price * 0.05;
    }

    public string GetTaxDetails()
    {
        return "5% Apparel Tax";
    }
}

public class AbsGroceries : AbsProduct
{
    public AbsGroceries(int productId, string name, double price)
        : base(productId, name, price)
    {
    }

    public override double CalculateDiscount()
    {
        return Price * 0.05;
    }
}

public class EcommercePlatformSystem
{
    public static void PrintProductReceipt(List<AbsProduct> products)
    {
        foreach (var p in products)
        {
            double discount = p.CalculateDiscount();
            double tax = (p is ITaxable taxable) ? taxable.CalculateTax() : 0.0;
            double finalPrice = p.Price + tax - discount;

            Console.WriteLine($"Product: {p.Name} | Base Price: {p.Price:C} | Tax: {tax:C} | Discount: {discount:C} | Final Price: {finalPrice:C}");
        }
    }

    public static void Run()
    {
        Console.WriteLine("--- E-Commerce Platform ---");

        List<AbsProduct> cart = new List<AbsProduct>
        {
            new AbsElectronics(1, "Smartphone", 800.00),
            new AbsClothing(2, "Jacket", 120.00),
            new AbsGroceries(3, "Organic Honey", 15.00)
        };

        PrintProductReceipt(cart);
    }
}
