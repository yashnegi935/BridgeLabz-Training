namespace CalculatorProblems;

public class BinarySearchPeakElement
{
    public static int FindPeakElementIndex(int[] arr)
    {
        int low = 0;
        int high = arr.Length - 1;

        while (low < high)
        {
            int mid = low + (high - low) / 2;

            if (arr[mid] < arr[mid + 1])
            {
                low = mid + 1;
            }
            else
            {
                high = mid;
            }
        }

        return low;
    }

    public static void Run()
    {
        Console.WriteLine("--- Binary Search: Peak Element ---");

        int[] arr = { 1, 2, 3, 1, 5, 6, 4 };
        int peakIndex = FindPeakElementIndex(arr);

        Console.WriteLine("Array: " + string.Join(", ", arr));
        Console.WriteLine($"Peak Element Index: {peakIndex} (Value: {arr[peakIndex]})");
    }
}
