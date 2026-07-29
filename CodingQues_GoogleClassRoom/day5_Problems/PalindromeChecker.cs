namespace CalculatorProblems;

public class PalindromeChecker
{
    public static void Run()
    {
        string text = GetInput();
        bool isPalindrome = CheckPalindrome(text);
        DisplayResult(text, isPalindrome);
    }

    private static string GetInput()
    {
        Console.Write("Enter a string to check if it is a palindrome: ");
        string? input = Console.ReadLine();
        return input ?? "";
    }

    private static bool CheckPalindrome(string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return false;
        }

        string cleaned = text.ToLower();
        int left = 0;
        int right = cleaned.Length - 1;

        while (left < right)
        {
            if (cleaned[left] != cleaned[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }

    private static void DisplayResult(string text, bool isPalindrome)
    {
        if (isPalindrome)
        {
            Console.WriteLine($"\"{text}\" IS a palindrome.");
        }
        else
        {
            Console.WriteLine($"\"{text}\" is NOT a palindrome.");
        }
    }
}
