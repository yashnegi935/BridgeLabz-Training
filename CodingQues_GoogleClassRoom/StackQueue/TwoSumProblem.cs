namespace CalculatorProblems;

public class TwoSumSolver
{
    public static int[] FindTwoSumIndices(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }
            map[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}

public class TwoSumProblem
{
    public static void Run()
    {
        Console.WriteLine("--- Two Sum Problem ---");

        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        int[] result = TwoSumSolver.FindTwoSumIndices(nums, target);

        Console.WriteLine("Array: " + string.Join(", ", nums));
        Console.WriteLine($"Target: {target}");
        if (result.Length == 2)
        {
            Console.WriteLine($"Indices: [{result[0]}, {result[1]}] (Values: {nums[result[0]]} + {nums[result[1]]})");
        }
        else
        {
            Console.WriteLine("No solution found.");
        }
    }
}
