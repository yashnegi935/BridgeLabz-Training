namespace CalculatorProblems;

public class PairSumFinder
{
    public static bool HasPairWithSum(int[] arr, int targetSum, out int val1, out int val2)
    {
        HashSet<int> seen = new HashSet<int>();
        val1 = 0;
        val2 = 0;

        foreach (int num in arr)
        {
            int complement = targetSum - num;
            if (seen.Contains(complement))
            {
                val1 = complement;
                val2 = num;
                return true;
            }
            seen.Add(num);
        }

        return false;
    }
}

public class PairWithGivenSum
{
    public static void Run()
    {
        Console.WriteLine("--- Check for Pair with Given Sum ---");

        int[] arr = { 10, 15, 3, 7, 8, 12 };
        int target = 19;

        if (PairSumFinder.HasPairWithSum(arr, target, out int v1, out int v2))
        {
            Console.WriteLine($"Target Sum {target} found with pair: {v1} + {v2}");
        }
        else
        {
            Console.WriteLine($"No pair found with target sum {target}.");
        }
    }
}
