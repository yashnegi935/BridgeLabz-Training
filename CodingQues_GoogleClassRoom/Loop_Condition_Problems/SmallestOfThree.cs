namespace CalculatorProblems;

public class SmallestOfThree
{
    public static void Run()
    {
        Console.Write("Enter First Number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Second Number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Third Number: ");
        int number3 = Convert.ToInt32(Console.ReadLine());

        bool isSmallest = number1 < number2 && number1 < number3;
        Console.WriteLine($"Is the first number the smallest? {isSmallest}");
    }
}
