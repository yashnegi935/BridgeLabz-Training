namespace CalculatorProblems;

public class ChocolateDivider
{
    public static void Run()
    {
        Console.Write("Enter number of chocolates: ");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of children: ");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());

        int[] result = FindRemainderAndQuotient(numberOfChocolates, numberOfChildren);

        Console.WriteLine($"Each child gets: {result[0]} chocolates");
        Console.WriteLine($"Remaining chocolates: {result[1]}");
    }

    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        int quotient = number / divisor;
        int remainder = number % divisor;

        return new int[] { quotient, remainder };
    }
}
