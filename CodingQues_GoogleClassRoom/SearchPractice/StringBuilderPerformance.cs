using System.Diagnostics;
using System.Text;

namespace CalculatorProblems;

public class StringBuilderPerformance
{
    public static void Run()
    {
        Console.WriteLine("--- StringBuilder Performance Comparison ---");

        int iterations = 50000;

        Stopwatch sw = Stopwatch.StartNew();
        string str = "";
        for (int i = 0; i < iterations; i++)
        {
            str += "a";
        }
        sw.Stop();
        long stringConcatTime = sw.ElapsedMilliseconds;

        sw.Restart();
        StringBuilder sb = new StringBuilder(iterations);
        for (int i = 0; i < iterations; i++)
        {
            sb.Append("a");
        }
        string sbResult = sb.ToString();
        sw.Stop();
        long stringBuilderTime = sw.ElapsedMilliseconds;

        Console.WriteLine($"String Concatenation (+) Time for {iterations} iterations: {stringConcatTime} ms");
        Console.WriteLine($"StringBuilder Append Time for {iterations} iterations      : {stringBuilderTime} ms");
    }
}
