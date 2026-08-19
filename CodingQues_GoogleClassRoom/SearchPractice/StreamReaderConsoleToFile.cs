using System.Text;

namespace CalculatorProblems;

public class StreamReaderConsoleToFile
{
    public static void Run()
    {
        Console.WriteLine("--- StreamReader: Read Input & Write to File ---");

        string sampleInput = "Sample user input line 1\nSample user input line 2";
        string tempPath = Path.Combine(Path.GetTempPath(), "user_input_log.txt");

        using (StringReader sr = new StringReader(sampleInput))
        {
            using (StreamWriter writer = new StreamWriter(tempPath, false, Encoding.UTF8))
            {
                string? inputLine;
                while ((inputLine = sr.ReadLine()) != null)
                {
                    writer.WriteLine(inputLine);
                }
            }
        }

        Console.WriteLine($"Data written to: {tempPath}");
        Console.WriteLine("Reading written file content:");

        using (FileStream fs = new FileStream(tempPath, FileMode.Open, FileAccess.Read))
        using (StreamReader reader = new StreamReader(fs, Encoding.UTF8))
        {
            Console.WriteLine(reader.ReadToEnd());
        }

        if (File.Exists(tempPath)) File.Delete(tempPath);
    }
}
