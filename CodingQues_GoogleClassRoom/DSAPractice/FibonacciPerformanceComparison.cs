using System.Diagnostics;

namespace CalculatorProblems;

public class FibonacciPerformanceComparison
{
    public static long FibonacciRecursive(int n)
    {
        if (n <= 1) return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    public static long FibonacciIterative(int n)
    {
        if (n <= 1) return n;
        long a = 0, b = 1;
        for (int i = 2; i <= n; i++)
        {
            long temp = a + b;
            a = b;
            b = temp;
        }
        return b;
    }

    public static void Run()
    {
        Console.WriteLine("--- Fibonacci Performance: Recursive (O(2^N)) vs Iterative (O(N)) ---");

        int[] values = { 10, 30, 35 };

        foreach (int n in values)
        {
            Stopwatch sw = Stopwatch.StartNew();
            long recResult = FibonacciRecursive(n);
            sw.Stop();
            long recTimeTicks = sw.ElapsedTicks;

            sw.Restart();
            long iterResult = FibonacciIterative(n);
            sw.Stop();
            long iterTimeTicks = sw.ElapsedTicks;

            Console.WriteLine($"Fibonacci({n}):");
            Console.WriteLine($"  Recursive O(2^N): Result = {recResult}, Time = {recTimeTicks} ticks ({(double)recTimeTicks / TimeSpan.TicksPerMillisecond:F3} ms)");
            Console.WriteLine($"  Iterative O(N)  : Result = {iterResult}, Time = {iterTimeTicks} ticks ({(double)iterTimeTicks / TimeSpan.TicksPerMillisecond:F3} ms)");
        }
    }
}
