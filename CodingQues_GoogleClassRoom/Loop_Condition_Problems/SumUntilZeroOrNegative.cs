namespace CalculatorProblems;

public class SumUntilZeroOrNegative
{
    public static void Run()
    {
        double total = 0.0;

        while (true)
        {
            Console.Write("Enter a number: ");
            double value = Convert.ToDouble(Console.ReadLine());

            if (value <= 0)
            {
                break;
            }

            total += value;
        }

        Console.WriteLine($"Total sum = {total}");
    }
}
