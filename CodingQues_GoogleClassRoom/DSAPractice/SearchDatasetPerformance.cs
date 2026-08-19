using System.Diagnostics;

namespace CalculatorProblems;

public class SearchDatasetPerformance
{
    public static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target) return i;
        }
        return -1;
    }

    public static int BinarySearch(int[] arr, int target)
    {
        int low = 0;
        int high = arr.Length - 1;
        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            if (arr[mid] == target) return mid;
            else if (arr[mid] < target) low = mid + 1;
            else high = mid - 1;
        }
        return -1;
    }

    public static void Run()
    {
        Console.WriteLine("--- Search Performance: Linear Search vs Binary Search ---");

        int[] sizes = { 1000, 10000, 100000 };

        foreach (int n in sizes)
        {
            int[] data = new int[n];
            for (int i = 0; i < n; i++) data[i] = i;

            int target = n - 1;

            Stopwatch sw = Stopwatch.StartNew();
            LinearSearch(data, target);
            sw.Stop();
            long linearTime = sw.ElapsedTicks;

            sw.Restart();
            BinarySearch(data, target);
            sw.Stop();
            long binaryTime = sw.ElapsedTicks;

            Console.WriteLine($"Dataset Size N = {n:N0}:");
            Console.WriteLine($"  Linear Search (O(N))   : {linearTime} ticks ({(double)linearTime / TimeSpan.TicksPerMillisecond:F3} ms)");
            Console.WriteLine($"  Binary Search (O(log N)): {binaryTime} ticks ({(double)binaryTime / TimeSpan.TicksPerMillisecond:F3} ms)");
        }
    }
}
