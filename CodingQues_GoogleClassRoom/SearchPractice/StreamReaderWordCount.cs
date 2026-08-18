namespace CalculatorProblems;

public class StreamReaderWordCount
{
    public static int CountWordInFile(string filePath, string targetWord)
    {
        int count = 0;
        using (StreamReader reader = new StreamReader(filePath))
        {
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] words = line.Split(new char[] { ' ', '.', ',', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string word in words)
                {
                    if (word.Equals(targetWord, StringComparison.OrdinalIgnoreCase))
                    {
                        count++;
                    }
                }
            }
        }
        return count;
    }

    public static void Run()
    {
        Console.WriteLine("--- StreamReader: Count Word Occurrences ---");

        string tempPath = Path.Combine(Path.GetTempPath(), "sample_wordcount.txt");
        File.WriteAllText(tempPath, "C# is a modern language. C# supports object-oriented programming. Learn C# today!");

        string target = "C#";
        int occurrences = CountWordInFile(tempPath, target);

        Console.WriteLine($"Target Word: '{target}'");
        Console.WriteLine($"Occurrences : {occurrences}");

        if (File.Exists(tempPath)) File.Delete(tempPath);
    }
}
