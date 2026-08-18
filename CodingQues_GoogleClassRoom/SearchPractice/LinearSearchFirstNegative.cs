namespace CalculatorProblems;

public class LinearSearchFirstNegative
{
    public static int FindFirstNegativeIndex(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                return i;
            }
        }
        return -1;
    }

    public static void Run()
    {
        Console.WriteLine("--- Linear Search: First Negative Number ---");

        int[] numbers = { 12, 45, 0, 8, -7, 19, -3 };
        int index = FindFirstNegativeIndex(numbers);

        Console.WriteLine("Array: " + string.Join(", ", numbers));
        if (index != -1)
        {
            Console.WriteLine($"First negative number found at index {index}: {numbers[index]}");
        }
        else
        {
            Console.WriteLine("No negative numbers found.");
        }
    }
}
