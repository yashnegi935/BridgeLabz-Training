namespace CalculatorProblems;

public class CountingSorter
{
    public static void Sort(int[] ages)
    {
        if (ages == null || ages.Length == 0) return;

        int minAge = ages[0];
        int maxAge = ages[0];

        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < minAge) minAge = ages[i];
            if (ages[i] > maxAge) maxAge = ages[i];
        }

        int range = maxAge - minAge + 1;
        int[] count = new int[range];
        int[] output = new int[ages.Length];

        for (int i = 0; i < ages.Length; i++)
        {
            count[ages[i] - minAge]++;
        }

        for (int i = 1; i < range; i++)
        {
            count[i] += count[i - 1];
        }

        for (int i = ages.Length - 1; i >= 0; i--)
        {
            output[count[ages[i] - minAge] - 1] = ages[i];
            count[ages[i] - minAge]--;
        }

        Array.Copy(output, 0, ages, 0, ages.Length);
    }
}

public class CountingSortStudentAges
{
    public static void Run()
    {
        Console.WriteLine("--- Counting Sort: Student Ages ---");

        int[] ages = { 14, 11, 18, 12, 10, 15, 14, 12, 17, 16, 10, 13 };

        Console.WriteLine("Original Student Ages: " + string.Join(", ", ages));

        CountingSorter.Sort(ages);

        Console.WriteLine("Sorted Student Ages  : " + string.Join(", ", ages));
    }
}
