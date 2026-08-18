namespace CalculatorProblems;

public class StreamReaderReadLine
{
    public static void Run()
    {
        Console.WriteLine("--- StreamReader: Read File Line by Line ---");

        string tempPath = Path.Combine(Path.GetTempPath(), "sample_readline.txt");
        File.WriteAllLines(tempPath, new string[]
        {
            "Line 1: Introduction to C#",
            "Line 2: Working with Streams",
            "Line 3: File I/O best practices"
        });

        using (StreamReader reader = new StreamReader(tempPath))
        {
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        if (File.Exists(tempPath)) File.Delete(tempPath);
    }
}
