namespace CalculatorProblems;

public class DivisibleByFive
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        bool isDivisible = number % 5 == 0;
        Console.WriteLine($"Is the number {number} divisible by 5? {isDivisible}");
    }
}
