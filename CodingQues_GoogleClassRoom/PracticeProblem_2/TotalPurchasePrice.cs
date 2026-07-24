namespace CalculatorProblems;

public class TotalPurchasePrice
{
    public static void Run()
    {
        Console.Write("Enter Unit Price: ");
        double unitPrice = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Quantity: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        double totalPrice = unitPrice * quantity;

        Console.WriteLine("The total purchase price is INR " + totalPrice + " if the quantity " + quantity + " and unit price is INR " + unitPrice);
    }
}