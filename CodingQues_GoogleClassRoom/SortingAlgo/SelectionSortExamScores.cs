namespace CalculatorProblems;

public class SelectionSorter
{
    public static void Sort(int[] scores)
    {
        int n = scores.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (scores[j] < scores[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = scores[minIndex];
            scores[minIndex] = scores[i];
            scores[i] = temp;
        }
    }
}

public class SelectionSortExamScores
{
    public static void Run()
    {
        Console.WriteLine("--- Selection Sort: Exam Scores ---");

        int[] scores = { 78, 95, 62, 84, 91, 55, 73 };

        Console.WriteLine("Original Exam Scores: " + string.Join(", ", scores));

        SelectionSorter.Sort(scores);

        Console.WriteLine("Sorted Exam Scores  : " + string.Join(", ", scores));
    }
}
