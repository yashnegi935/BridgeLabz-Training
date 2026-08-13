namespace CalculatorProblems;

public class ZeroSumSubarrayFinder
{
    public static List<Tuple<int, int>> FindSubarrays(int[] arr)
    {
        List<Tuple<int, int>> result = new List<Tuple<int, int>>();
        Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
        int sum = 0;

        map[0] = new List<int> { -1 };

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];

            if (map.ContainsKey(sum))
            {
                foreach (int prevIndex in map[sum])
                {
                    result.Add(new Tuple<int, int>(prevIndex + 1, i));
                }
            }
            else
            {
                map[sum] = new List<int>();
            }
            map[sum].Add(i);
        }

        return result;
    }
}

public class SubarraysWithZeroSum
{
    public static void Run()
    {
        Console.WriteLine("--- Find All Subarrays with Zero Sum ---");

        int[] arr = { 6, 3, -1, -3, 4, -2, 2, 4, 6, -12, -7 };
        var subarrays = ZeroSumSubarrayFinder.FindSubarrays(arr);

        Console.WriteLine("Array: " + string.Join(", ", arr));
        Console.WriteLine("Subarrays with Sum 0:");
        foreach (var sub in subarrays)
        {
            Console.WriteLine($"Subarray from index {sub.Item1} to {sub.Item2}");
        }
    }
}
