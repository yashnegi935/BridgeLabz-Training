namespace CalculatorProblems;

public class AddTwoNumbers
{
    public static void Run()
    {
        Console.Write("Enter First Number : ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Second Number : ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Sum = {a + b}");
    }
}