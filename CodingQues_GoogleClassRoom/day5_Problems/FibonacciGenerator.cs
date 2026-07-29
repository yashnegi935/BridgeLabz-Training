namespace CalculatorProblems;

public class FibonacciGenerator
{
    public static void Run()
    {
        Console.Write("Enter number of terms for Fibonacci sequence: ");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int terms) && terms > 0)
        {
            GenerateAndPrintFibonacci(terms);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }
    }

    private static void GenerateAndPrintFibonacci(int terms)
    {
        long a = 0;
        long b = 1;

        Console.Write($"Fibonacci sequence ({terms} terms): ");

        for (int i = 0; i < terms; i++)
        {
            Console.Write($"{a} ");
            long temp = a + b;
            a = b;
            b = temp;
        }

        Console.WriteLine();
    }
}
