namespace CalculatorProblems;

public class NumberCheckerQ4
{
    public static void Run()
    {
        int number = 12321;
        int count = NumberChecker.CountDigits(number);
        int[] digits = NumberChecker.StoreDigits(number);
        int[] reversed = NumberChecker.ReverseArray(digits);
        bool areEqual = NumberChecker.AreArraysEqual(digits, reversed);
        bool isPalindrome = NumberChecker.IsPalindrome(digits);
        bool isDuck = NumberChecker.IsDuckNumber(digits);

        Console.WriteLine($"Number: {number}");
        Console.WriteLine($"Count of digits: {count}");

        Console.Write("Original Digits: ");
        for (int i = 0; i < digits.Length; i++)
        {
            Console.Write(digits[i] + " ");
        }
        Console.WriteLine();

        Console.Write("Reversed Digits: ");
        for (int i = 0; i < reversed.Length; i++)
        {
            Console.Write(reversed[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine($"Arrays Equal: {areEqual}");
        Console.WriteLine($"Is Palindrome: {isPalindrome}");
        Console.WriteLine($"Is Duck Number: {isDuck}");
    }
}
