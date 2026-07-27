namespace CalculatorProblems;

public class FootballTeamHeight
{
    public static void Run()
    {
        Random random = new Random();
        int[] heights = new int[11];
        for (int i = 0; i < heights.Length; i++)
        {
            heights[i] = random.Next(150, 251);
        }

        Console.WriteLine("Player Heights (in cm):");
        for (int i = 0; i < heights.Length; i++)
        {
            Console.Write(heights[i] + " ");
        }
        Console.WriteLine();

        int sum = FindSum(heights);
        double mean = FindMean(heights);
        int shortest = FindShortest(heights);
        int tallest = FindTallest(heights);

        Console.WriteLine($"Sum of Heights: {sum} cm");
        Console.WriteLine($"Mean Height: {mean:F2} cm");
        Console.WriteLine($"Shortest Height: {shortest} cm");
        Console.WriteLine($"Tallest Height: {tallest} cm");
    }

    public static int FindSum(int[] heights)
    {
        int sum = 0;
        for (int i = 0; i < heights.Length; i++)
        {
            sum += heights[i];
        }
        return sum;
    }

    public static double FindMean(int[] heights)
    {
        if (heights.Length == 0) return 0;
        int sum = FindSum(heights);
        return (double)sum / heights.Length;
    }

    public static int FindShortest(int[] heights)
    {
        int min = heights[0];
        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] < min)
            {
                min = heights[i];
            }
        }
        return min;
    }

    public static int FindTallest(int[] heights)
    {
        int max = heights[0];
        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > max)
            {
                max = heights[i];
            }
        }
        return max;
    }
}
