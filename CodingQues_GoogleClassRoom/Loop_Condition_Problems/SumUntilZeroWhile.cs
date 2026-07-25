namespace CalculatorProblems;

public class SumUntilZeroWhile
{
    public static void Run()
    {
        double total = 0.0;
        Console.Write("Enter a number: ");
        double value = Convert.ToDouble(Console.ReadLine());

        while (value != 0)
        {
            total += value;
            Console.Write("Enter a number: ");
            value = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine($"Total sum = {total}");
    }
}
