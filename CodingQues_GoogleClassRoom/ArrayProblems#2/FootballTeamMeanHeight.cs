namespace CalculatorProblems;

public class FootballTeamMeanHeight
{
    public static void Run()
    {
        double[] heights = new double[11];
        double sum = 0.0;

        Console.WriteLine("Enter heights of 11 football players:");
        for (int i = 0; i < heights.Length; i++)
        {
            Console.Write($"Player {i + 1} height: ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
            sum += heights[i];
        }

        double mean = sum / 11;
        Console.WriteLine($"Mean height of the football team: {mean:F2}");
    }
}
