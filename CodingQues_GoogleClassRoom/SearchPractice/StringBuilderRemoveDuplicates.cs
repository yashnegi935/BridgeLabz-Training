using System.Text;

namespace CalculatorProblems;

public class StringBuilderRemoveDuplicates
{
    public static string RemoveDuplicates(string input)
    {
        if (string.IsNullOrEmpty(input)) return input;

        StringBuilder sb = new StringBuilder();
        HashSet<char> seen = new HashSet<char>();

        foreach (char ch in input)
        {
            if (!seen.Contains(ch))
            {
                seen.Add(ch);
                sb.Append(ch);
            }
        }

        return sb.ToString();
    }

    public static void Run()
    {
        Console.WriteLine("--- StringBuilder: Remove Duplicates ---");

        string text = "programming";
        string result = RemoveDuplicates(text);

        Console.WriteLine($"Original Text: {text}");
        Console.WriteLine($"Result Text  : {result}");
    }
}
