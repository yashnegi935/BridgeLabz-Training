namespace CalculatorProblems;

public interface IDiscountable
{
    void ApplyDiscount(double percentage);
    string GetDiscountDetails();
}

public abstract class AbsFoodItem
{
    private string itemName;
    private double price;
    private int quantity;

    public string ItemName
    {
        get { return itemName; }
    }

    public double Price
    {
        get { return price; }
        protected set { price = value; }
    }

    public int Quantity
    {
        get { return quantity; }
    }

    public AbsFoodItem(string itemName, double price, int quantity)
    {
        this.itemName = itemName;
        this.price = price;
        this.quantity = quantity;
    }

    public abstract double CalculateTotalPrice();

    public virtual void GetItemDetails()
    {
        Console.WriteLine($"Item: {ItemName} | Quantity: {Quantity} | Price Per Unit: {Price:C} | Total: {CalculateTotalPrice():C}");
    }
}

public class VegItem : AbsFoodItem, IDiscountable
{
    private double discountPercentage = 0;

    public VegItem(string itemName, double price, int quantity)
        : base(itemName, price, quantity)
    {
    }

    public override double CalculateTotalPrice()
    {
        double subtotal = Price * Quantity;
        return subtotal - (subtotal * (discountPercentage / 100));
    }

    public void ApplyDiscount(double percentage)
    {
        discountPercentage = percentage;
    }

    public string GetDiscountDetails()
    {
        return $"{discountPercentage}% Veg Promo Discount";
    }
}

public class NonVegItem : AbsFoodItem, IDiscountable
{
    private double discountPercentage = 0;
    public double NonVegSurcharge { get; set; } = 2.50;

    public NonVegItem(string itemName, double price, int quantity)
        : base(itemName, price, quantity)
    {
    }

    public override double CalculateTotalPrice()
    {
        double subtotal = (Price * Quantity) + (NonVegSurcharge * Quantity);
        return subtotal - (subtotal * (discountPercentage / 100));
    }

    public void ApplyDiscount(double percentage)
    {
        discountPercentage = percentage;
    }

    public string GetDiscountDetails()
    {
        return $"{discountPercentage}% Non-Veg Promo Discount";
    }
}

public class OnlineFoodDeliverySystem
{
    public static void Run()
    {
        Console.WriteLine("--- Online Food Delivery System ---");

        VegItem vegPaneer = new VegItem("Paneer Butter Masala", 12.00, 2);
        vegPaneer.ApplyDiscount(10);

        NonVegItem nonVegChicken = new NonVegItem("Grilled Chicken", 16.00, 1);
        nonVegChicken.ApplyDiscount(5);

        List<AbsFoodItem> orderList = new List<AbsFoodItem> { vegPaneer, nonVegChicken };

        foreach (var food in orderList)
        {
            food.GetItemDetails();
        }
    }
}
