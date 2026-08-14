namespace CalculatorProblems;

public class HeapSorter
{
    public static void Sort(double[] salaries)
    {
        int n = salaries.Length;

        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(salaries, n, i);
        }

        for (int i = n - 1; i > 0; i--)
        {
            double temp = salaries[0];
            salaries[0] = salaries[i];
            salaries[i] = temp;

            Heapify(salaries, i, 0);
        }
    }

    private static void Heapify(double[] salaries, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        if (left < n && salaries[left] > salaries[largest])
        {
            largest = left;
        }

        if (right < n && salaries[right] > salaries[largest])
        {
            largest = right;
        }

        if (largest != i)
        {
            double swap = salaries[i];
            salaries[i] = salaries[largest];
            salaries[largest] = swap;

            Heapify(salaries, n, largest);
        }
    }
}

public class HeapSortSalaryDemands
{
    public static void Run()
    {
        Console.WriteLine("--- Heap Sort: Job Applicant Salary Demands ---");

        double[] salaryDemands = { 75000, 110000, 60000, 95000, 130000, 82000 };

        Console.WriteLine("Original Salary Demands: " + string.Join(", ", salaryDemands.Select(s => s.ToString("C"))));

        HeapSorter.Sort(salaryDemands);

        Console.WriteLine("Sorted Salary Demands  : " + string.Join(", ", salaryDemands.Select(s => s.ToString("C"))));
    }
}
