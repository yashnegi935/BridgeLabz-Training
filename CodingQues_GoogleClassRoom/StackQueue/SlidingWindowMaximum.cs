namespace CalculatorProblems;

public class SlidingWindowHelper
{
    public static int[] FindMaxInSlidingWindow(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0 || k <= 0) return Array.Empty<int>();

        int n = nums.Length;
        int[] result = new int[n - k + 1];
        LinkedList<int> deque = new LinkedList<int>();

        for (int i = 0; i < n; i++)
        {
            if (deque.Count > 0 && deque.First!.Value <= i - k)
            {
                deque.RemoveFirst();
            }

            while (deque.Count > 0 && nums[deque.Last!.Value] <= nums[i])
            {
                deque.RemoveLast();
            }

            deque.AddLast(i);

            if (i >= k - 1)
            {
                result[i - k + 1] = nums[deque.First!.Value];
            }
        }

        return result;
    }
}

public class SlidingWindowMaximum
{
    public static void Run()
    {
        Console.WriteLine("--- Sliding Window Maximum ---");

        int[] arr = { 1, 3, -1, -3, 5, 3, 6, 7 };
        int k = 3;

        int[] maxes = SlidingWindowHelper.FindMaxInSlidingWindow(arr, k);

        Console.WriteLine("Array: " + string.Join(", ", arr));
        Console.WriteLine($"Sliding Window Max (k={k}): " + string.Join(", ", maxes));
    }
}
