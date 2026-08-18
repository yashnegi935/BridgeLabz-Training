namespace CalculatorProblems;

public class StringBuilderConcat
{
    public static string ConcatenateArray(string[] words)
    {
        if (words == null || words.Length == 0) return string.Empty;

        StringBuilder sb = new StringBuilder(words.Length * 10);
        foreach (string word in words)
        {
            sb.Append(word).Append(" ");
        }

        return sb.ToString().TrimEnd();
    }

    public static void Run()
    {
        Console.WriteLine("--- StringBuilder: Concatenate Strings Efficiently ---");

        string[] words = { "The", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" };
        string sentence = ConcatenateArray(words);

        Console.WriteLine("String Array: " + string.Join(", ", words));
        Console.WriteLine("Concatenated: " + sentence);
    }
}
