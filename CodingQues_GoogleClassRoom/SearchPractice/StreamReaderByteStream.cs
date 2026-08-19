using System.Text;

namespace CalculatorProblems;

public class StreamReaderByteStream
{
    public static void Run()
    {
        Console.WriteLine("--- StreamReader: Convert Byte Stream to Characters ---");

        string tempPath = Path.Combine(Path.GetTempPath(), "sample_bytestream.bin");
        byte[] binaryData = Encoding.UTF8.GetBytes("Hello World from Byte Stream conversion!");
        File.WriteAllBytes(tempPath, binaryData);

        using (FileStream fs = new FileStream(tempPath, FileMode.Open, FileAccess.Read))
        using (StreamReader reader = new StreamReader(fs, Encoding.UTF8))
        {
            string text = reader.ReadToEnd();
            Console.WriteLine("Read Character Content:");
            Console.WriteLine(text);
        }

        if (File.Exists(tempPath)) File.Delete(tempPath);
    }
}
