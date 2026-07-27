namespace CalculatorProblems;

public class YoungestTallestFriends
{
    public static void Run()
    {
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];

        for (int i = 0; i < names.Length; i++)
        {
            Console.Write($"Enter age for {names[i]}: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Enter height (in cm) for {names[i]}: ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }

        string youngest = FindYoungest(names, ages);
        string tallest = FindTallest(names, heights);

        Console.WriteLine($"Youngest friend is: {youngest}");
        Console.WriteLine($"Tallest friend is: {tallest}");
    }

    public static string FindYoungest(string[] names, int[] ages)
    {
        int minAgeIndex = 0;
        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < ages[minAgeIndex])
            {
                minAgeIndex = i;
            }
        }
        return names[minAgeIndex];
    }

    public static string FindTallest(string[] names, double[] heights)
    {
        int maxHeightIndex = 0;
        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > heights[maxHeightIndex])
            {
                maxHeightIndex = i;
            }
        }
        return names[maxHeightIndex];
    }
}
