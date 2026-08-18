using System.Text;

namespace CalculatorProblems;

public class StringBuilderReverse
{
    public static string ReverseString(string input)
    {
        if (string.IsNullOrEmpty(input)) return input;

        StringBuilder sb = new StringBuilder(input.Length);
        for (int i = input.Length - 1; i >= 0; i--)
        {
            sb.Append(input[i]);
        }
        return sb.ToString();
    }

    public static void Run()
    {
        Console.WriteLine("--- StringBuilder: Reverse a String ---");

        string original = "hello";
        string reversed = ReverseString(original);

        Console.WriteLine($"Original: {original}");
        Console.WriteLine($"Reversed: {reversed}");
    }
}
