namespace CalculatorProblems;

public class LinearSearchSentenceWord
{
    public static int FindSentenceWithWord(string[] sentences, string targetWord)
    {
        for (int i = 0; i < sentences.Length; i++)
        {
            string[] words = sentences[i].Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                if (word.Equals(targetWord, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }
        }
        return -1;
    }

    public static void Run()
    {
        Console.WriteLine("--- Linear Search: Word in Sentences ---");

        string[] sentences = new string[]
        {
            "The weather is lovely today.",
            "C# programming language is very versatile.",
            "Linear search checks elements one by one."
        };

        string target = "versatile";
        int index = FindSentenceWithWord(sentences, target);

        Console.WriteLine($"Target Word: '{target}'");
        if (index != -1)
        {
            Console.WriteLine($"Found in Sentence [{index}]: \"{sentences[index]}\"");
        }
        else
        {
            Console.WriteLine("Word not found in any sentence.");
        }
    }
}
