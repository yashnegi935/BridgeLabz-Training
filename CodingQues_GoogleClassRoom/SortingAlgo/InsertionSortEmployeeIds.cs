namespace CalculatorProblems;

public class InsertionSorter
{
    public static void Sort(int[] ids)
    {
        int n = ids.Length;
        for (int i = 1; i < n; i++)
        {
            int key = ids[i];
            int j = i - 1;

            while (j >= 0 && ids[j] > key)
            {
                ids[j + 1] = ids[j];
                j--;
            }
            ids[j + 1] = key;
        }
    }
}

public class InsertionSortEmployeeIds
{
    public static void Run()
    {
        Console.WriteLine("--- Insertion Sort: Employee IDs ---");

        int[] employeeIds = { 1054, 1012, 1098, 1023, 1005, 1076 };

        Console.WriteLine("Original Employee IDs: " + string.Join(", ", employeeIds));

        InsertionSorter.Sort(employeeIds);

        Console.WriteLine("Sorted Employee IDs  : " + string.Join(", ", employeeIds));
    }
}
