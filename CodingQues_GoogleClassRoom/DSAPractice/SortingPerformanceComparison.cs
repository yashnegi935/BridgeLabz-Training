using System.Diagnostics;

namespace CalculatorProblems;

public class SortingPerformanceComparison
{
    public static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            bool swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped) break;
        }
    }

    public static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }

    private static void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;
        int[] leftArr = new int[n1];
        int[] rightArr = new int[n2];

        Array.Copy(arr, left, leftArr, 0, n1);
        Array.Copy(arr, mid + 1, rightArr, 0, n2);

        int i = 0, j = 0, k = left;
        while (i < n1 && j < n2)
        {
            if (leftArr[i] <= rightArr[j]) arr[k++] = leftArr[i++];
            else arr[k++] = rightArr[j++];
        }
        while (i < n1) arr[k++] = leftArr[i++];
        while (j < n2) arr[k++] = rightArr[j++];
    }

    public static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivot = Partition(arr, low, high);
            QuickSort(arr, low, pivot - 1);
            QuickSort(arr, pivot + 1, high);
        }
    }

    private static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;
        for (int j = low; j < high; j++)
        {
            if (arr[j] <= pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        int swap = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = swap;
        return i + 1;
    }

    public static void Run()
    {
        Console.WriteLine("--- Sorting Performance: Bubble vs Merge vs Quick Sort ---");

        int[] sizes = { 1000, 5000 };
        Random rand = new Random(42);

        foreach (int n in sizes)
        {
            int[] original = new int[n];
            for (int i = 0; i < n; i++) original[i] = rand.Next(1, 100000);

            int[] bArr = (int[])original.Clone();
            int[] mArr = (int[])original.Clone();
            int[] qArr = (int[])original.Clone();

            Stopwatch sw = Stopwatch.StartNew();
            BubbleSort(bArr);
            sw.Stop();
            long bubbleMs = sw.ElapsedMilliseconds;

            sw.Restart();
            MergeSort(mArr, 0, mArr.Length - 1);
            sw.Stop();
            long mergeMs = sw.ElapsedMilliseconds;

            sw.Restart();
            QuickSort(qArr, 0, qArr.Length - 1);
            sw.Stop();
            long quickMs = sw.ElapsedMilliseconds;

            Console.WriteLine($"Dataset Size N = {n:N0}:");
            Console.WriteLine($"  Bubble Sort (O(N^2))    : {bubbleMs} ms");
            Console.WriteLine($"  Merge Sort  (O(N log N)): {mergeMs} ms");
            Console.WriteLine($"  Quick Sort  (O(N log N)): {quickMs} ms");
        }
    }
}
