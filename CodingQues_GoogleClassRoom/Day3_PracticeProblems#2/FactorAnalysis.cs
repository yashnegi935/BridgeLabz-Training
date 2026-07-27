namespace CalculatorProblems;

public class FactorAnalysis
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] factors = FindFactors(number);
        int sum = FindSum(factors);
        double sumOfSquares = FindSumOfSquares(factors);
        long product = FindProduct(factors);

        Console.Write("Factors: ");
        for (int i = 0; i < factors.Length; i++)
        {
            Console.Write(factors[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine($"Sum of factors: {sum}");
        Console.WriteLine($"Sum of squares of factors: {sumOfSquares}");
        Console.WriteLine($"Product of factors: {product}");
    }

    public static int[] FindFactors(int number)
    {
        int count = 0;
        for (int i = 1; i <= Math.Abs(number); i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }

        int[] factors = new int[count];
        int index = 0;
        for (int i = 1; i <= Math.Abs(number); i++)
        {
            if (number % i == 0)
            {
                factors[index] = i;
                index++;
            }
        }

        return factors;
    }

    public static int FindSum(int[] factors)
    {
        int sum = 0;
        for (int i = 0; i < factors.Length; i++)
        {
            sum += factors[i];
        }
        return sum;
    }

    public static double FindSumOfSquares(int[] factors)
    {
        double sumOfSquares = 0;
        for (int i = 0; i < factors.Length; i++)
        {
            sumOfSquares += Math.Pow(factors[i], 2);
        }
        return sumOfSquares;
    }

    public static long FindProduct(int[] factors)
    {
        long product = 1;
        for (int i = 0; i < factors.Length; i++)
        {
            product *= factors[i];
        }
        return product;
    }
}
