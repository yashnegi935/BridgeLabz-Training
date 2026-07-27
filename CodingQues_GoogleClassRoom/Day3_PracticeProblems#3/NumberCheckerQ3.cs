namespace CalculatorProblems;

public class NumberCheckerQ3
{
    public static void Run()
    {
        int number = 21;
        int count = NumberChecker.CountDigits(number);
        int[] digits = NumberChecker.StoreDigits(number);
        int sum = NumberChecker.SumOfDigits(digits);
        double sumSquares = NumberChecker.SumOfSquaresOfDigits(digits);
        bool isHarshad = NumberChecker.IsHarshadNumber(number, digits);
        int[,] frequency = NumberChecker.GetDigitFrequency(digits);

        Console.WriteLine($"Number: {number}");
        Console.WriteLine($"Count of digits: {count}");
        Console.WriteLine($"Sum of digits: {sum}");
        Console.WriteLine($"Sum of squares of digits: {sumSquares}");
        Console.WriteLine($"Is Harshad Number: {isHarshad}");

        Console.WriteLine("Digit Frequency:");
        Console.WriteLine("Digit\tFrequency");
        for (int i = 0; i < frequency.GetLength(0); i++)
        {
            Console.WriteLine($"{frequency[i, 0]}\t{frequency[i, 1]}");
        }
    }
}
