namespace CalculatorProblems;

public class RecursiveSumNaturalNumbers
{
    public static void Run()
    {
        Console.Write("Enter a natural number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Invalid input. Not a natural number.");
            return;
        }

        int recursiveSum = CalculateRecursiveSum(n);
        int formulaSum = CalculateFormulaSum(n);

        Console.WriteLine($"Recursive Sum: {recursiveSum}");
        Console.WriteLine($"Formula Sum: {formulaSum}");

        if (recursiveSum == formulaSum)
        {
            Console.WriteLine("Both computations are correct and match!");
        }
        else
        {
            Console.WriteLine("Computations do not match.");
        }
    }

    public static int CalculateRecursiveSum(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        return n + CalculateRecursiveSum(n - 1);
    }

    public static int CalculateFormulaSum(int n)
    {
        return (n * (n + 1)) / 2;
    }
}
