namespace CalculatorProblems;

public class NumberCheckerQ2
{
    public static void Run()
    {
        int number = 153;
        int count = NumberChecker.CountDigits(number);
        int[] digits = NumberChecker.StoreDigits(number);
        bool isDuck = NumberChecker.IsDuckNumber(digits);
        bool isArmstrong = NumberChecker.IsArmstrongNumber(number, digits);

        NumberChecker.FindLargestAndSecondLargest(digits, out int largest, out int secondLargest);
        NumberChecker.FindSmallestAndSecondSmallest(digits, out int smallest, out int secondSmallest);

        Console.WriteLine($"Number: {number}");
        Console.WriteLine($"Digit Count: {count}");
        Console.Write("Digits Array: ");
        for (int i = 0; i < digits.Length; i++)
        {
            Console.Write(digits[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine($"Is Duck Number: {isDuck}");
        Console.WriteLine($"Is Armstrong Number: {isArmstrong}");
        Console.WriteLine($"Largest: {largest}, Second Largest: {secondLargest}");
        Console.WriteLine($"Smallest: {smallest}, Second Smallest: {secondSmallest}");
    }
}
