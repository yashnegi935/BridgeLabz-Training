namespace CalculatorProblems;

public class LinearBinarySearchChallenge
{
    public static int FindFirstMissingPositive(int[] nums)
    {
        HashSet<int> positives = new HashSet<int>();
        foreach (int num in nums)
        {
            if (num > 0) positives.Add(num);
        }

        int candidate = 1;
        while (positives.Contains(candidate))
        {
            candidate++;
        }
        return candidate;
    }

    public static int BinarySearchTarget(int[] arr, int target)
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
        Console.WriteLine("--- Linear and Binary Search Challenge ---");

        int[] list = { 3, 4, -1, 1, 7, 8, 2 };

        Console.WriteLine("Original List: " + string.Join(", ", list));

        int firstMissing = FindFirstMissingPositive(list);
        Console.WriteLine($"First Missing Positive Integer (Linear Search): {firstMissing}");

        int[] sortedList = (int[])list.Clone();
        Array.Sort(sortedList);
        Console.WriteLine("Sorted List: " + string.Join(", ", sortedList));

        int targetNum = 7;
        int targetIndex = BinarySearchTarget(sortedList, targetNum);
        Console.WriteLine($"Target {targetNum} Index in Sorted List (Binary Search): {targetIndex}");
    }
}
