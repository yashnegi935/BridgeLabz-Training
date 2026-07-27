namespace CalculatorProblems;

public class SumNaturalNumbers
{
    public static void Run()
    {
        Console.Write("Enter n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = CalculateSum(n);

        Console.WriteLine($"Sum of first {n} natural numbers is {sum}");
    }

    public static int CalculateSum(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }
}
