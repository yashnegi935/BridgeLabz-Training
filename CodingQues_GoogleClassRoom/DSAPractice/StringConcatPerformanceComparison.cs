using System.Diagnostics;
using System.Text;

namespace CalculatorProblems;

public class StringConcatPerformanceComparison
{
    public static void Run()
    {
        Console.WriteLine("--- String Concatenation Performance: string vs StringBuilder ---");

        int[] counts = { 1000, 10000 };

        foreach (int n in counts)
        {
            Stopwatch sw = Stopwatch.StartNew();
            string str = "";
            for (int i = 0; i < n; i++)
            {
                str += "a";
            }
            sw.Stop();
            long stringTime = sw.ElapsedMilliseconds;

            sw.Restart();
            StringBuilder sb = new StringBuilder(n);
            for (int i = 0; i < n; i++)
            {
                sb.Append("a");
            }
            string sbResult = sb.ToString();
            sw.Stop();
            long sbTime = sw.ElapsedMilliseconds;

            Console.WriteLine($"Iterations N = {n:N0}:");
            Console.WriteLine($"  string Immutable Concatenation (+) : {stringTime} ms");
            Console.WriteLine($"  StringBuilder Mutable Append       : {sbTime} ms");
        }
    }
}
