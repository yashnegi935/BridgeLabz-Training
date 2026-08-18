namespace CalculatorProblems;

public class BinarySearchFirstLastOccurrence
{
    public static int FindFirst(int[] arr, int target)
    {
        int low = 0, high = arr.Length - 1, res = -1;
        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            if (arr[mid] == target)
            {
                res = mid;
                high = mid - 1;
            }
            else if (arr[mid] < target) low = mid + 1;
            else high = mid - 1;
        }
        return res;
    }

    public static int FindLast(int[] arr, int target)
    {
        int low = 0, high = arr.Length - 1, res = -1;
        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            if (arr[mid] == target)
            {
                res = mid;
                low = mid + 1;
            }
            else if (arr[mid] < target) low = mid + 1;
            else high = mid - 1;
        }
        return res;
    }

    public static void Run()
    {
        Console.WriteLine("--- Binary Search: First and Last Occurrence ---");

        int[] sortedArr = { 5, 7, 7, 8, 8, 8, 10 };
        int target = 8;

        int first = FindFirst(sortedArr, target);
        int last = FindLast(sortedArr, target);

        Console.WriteLine("Sorted Array: " + string.Join(", ", sortedArr));
        Console.WriteLine($"Target: {target}");
        Console.WriteLine($"First Occurrence Index: {first}");
        Console.WriteLine($"Last Occurrence Index : {last}");
    }
}
