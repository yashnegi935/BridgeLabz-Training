namespace CalculatorProblems;

public class FactorialRecursion
{
    public static void Run()
    {
        int number = GetNumberInput();
        if (number < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
            return;
        }

        long result = CalculateFactorial(number);
        DisplayFactorialResult(number, result);
    }

    private static int GetNumberInput()
    {
        Console.Write("Enter a non-negative integer for factorial calculation: ");
        string? input = Console.ReadLine();
        if (int.TryParse(input, out int result))
        {
            return result;
        }
        return -1;
    }

    private static long CalculateFactorial(int n)
    {
        if (n <= 1)
        {
            return 1;
        }

        return n * CalculateFactorial(n - 1);
    }

    private static void DisplayFactorialResult(int number, long result)
    {
        Console.WriteLine($"Factorial of {number} ({number}!) = {result}");
    }
}
