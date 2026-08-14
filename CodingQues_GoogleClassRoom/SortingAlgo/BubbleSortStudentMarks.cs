namespace CalculatorProblems;

public class BubbleSorter
{
    public static void Sort(int[] marks)
    {
        int n = marks.Length;
        for (int i = 0; i < n - 1; i++)
        {
            bool swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                if (marks[j] > marks[j + 1])
                {
                    int temp = marks[j];
                    marks[j] = marks[j + 1];
                    marks[j + 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped) break;
        }
    }
}

public class BubbleSortStudentMarks
{
    public static void Run()
    {
        Console.WriteLine("--- Bubble Sort: Student Marks ---");

        int[] marks = { 85, 92, 67, 74, 90, 58, 88 };

        Console.WriteLine("Original Marks: " + string.Join(", ", marks));

        BubbleSorter.Sort(marks);

        Console.WriteLine("Sorted Marks  : " + string.Join(", ", marks));
    }
}
