namespace CalculatorProblems;

public class ConsecutiveSequenceFinder
{
    public static int FindLongestConsecutive(int[] nums)
    {
        HashSet<int> numSet = new HashSet<int>(nums);
        int longestStreak = 0;

        foreach (int num in numSet)
        {
            if (!numSet.Contains(num - 1))
            {
                int currentNum = num;
                int currentStreak = 1;

                while (numSet.Contains(currentNum + 1))
                {
                    currentNum += 1;
                    currentStreak += 1;
                }

                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }

        return longestStreak;
    }
}

public class LongestConsecutiveSequence
{
    public static void Run()
    {
        Console.WriteLine("--- Longest Consecutive Sequence ---");

        int[] nums = { 100, 4, 200, 1, 3, 2 };
        int length = ConsecutiveSequenceFinder.FindLongestConsecutive(nums);

        Console.WriteLine("Array: " + string.Join(", ", nums));
        Console.WriteLine($"Length of Longest Consecutive Sequence: {length}");
    }
}
