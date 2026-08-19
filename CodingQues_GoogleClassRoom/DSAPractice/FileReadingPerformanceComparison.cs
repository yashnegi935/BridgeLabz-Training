using System.Diagnostics;
using System.Text;

namespace CalculatorProblems;

public class FileReadingPerformanceComparison
{
    public static void Run()
    {
        Console.WriteLine("--- Large File Reading Performance: StreamReader vs FileStream ---");

        string tempPath = Path.Combine(Path.GetTempPath(), "large_test_file.dat");
        byte[] sampleChunk = Encoding.UTF8.GetBytes("Line of test data for performance analysis.\n");

        using (FileStream fs = new FileStream(tempPath, FileMode.Create, FileAccess.Write))
        {
            for (int i = 0; i < 50000; i++)
            {
                fs.Write(sampleChunk, 0, sampleChunk.Length);
            }
        }

        Stopwatch sw = Stopwatch.StartNew();
        using (StreamReader reader = new StreamReader(tempPath))
        {
            while (reader.ReadLine() != null) { }
        }
        sw.Stop();
        long streamReaderMs = sw.ElapsedMilliseconds;

        sw.Restart();
        using (FileStream fs = new FileStream(tempPath, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[8192];
            while (fs.Read(buffer, 0, buffer.Length) > 0) { }
        }
        sw.Stop();
        long fileStreamMs = sw.ElapsedMilliseconds;

        Console.WriteLine($"File Size: {new FileInfo(tempPath).Length / 1024} KB");
        Console.WriteLine($"  StreamReader Line-by-Line Time : {streamReaderMs} ms");
        Console.WriteLine($"  FileStream Chunk-Buffered Time: {fileStreamMs} ms");

        if (File.Exists(tempPath)) File.Delete(tempPath);
    }
}
