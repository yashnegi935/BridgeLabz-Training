namespace CalculatorProblems;

public class YoungestAndTallestFriendArray
{
    public static void Run()
    {
        string[] friends = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter age of {friends[i]}: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Enter height of {friends[i]} (in cm or m): ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }

        int minAgeIndex = 0;
        int maxHeightIndex = 0;

        for (int i = 1; i < 3; i++)
        {
            if (ages[i] < ages[minAgeIndex])
            {
                minAgeIndex = i;
            }

            if (heights[i] > heights[maxHeightIndex])
            {
                maxHeightIndex = i;
            }
        }

        Console.WriteLine($"Youngest friend: {friends[minAgeIndex]} with age {ages[minAgeIndex]}");
        Console.WriteLine($"Tallest friend: {friends[maxHeightIndex]} with height {heights[maxHeightIndex]}");
    }
}
