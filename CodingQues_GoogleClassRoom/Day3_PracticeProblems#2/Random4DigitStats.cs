namespace CalculatorProblems;

public class Random4DigitStats
{
    public static void Run()
    {
        int size = 5;
        int[] numbers = Generate4DigitRandomArray(size);

        Console.Write("Generated 4-digit random numbers: ");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();

        double[] stats = FindAverageMinMax(numbers);

        Console.WriteLine($"Average value: {stats[0]}");
        Console.WriteLine($"Minimum value: {stats[1]}");
        Console.WriteLine($"Maximum value: {stats[2]}");
    }

    public static int[] Generate4DigitRandomArray(int size)
    {
        Random random = new Random();
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(1000, 10000);
        }

        return array;
    }

    public static double[] FindAverageMinMax(int[] numbers)
    {
        double sum = 0;
        int min = numbers[0];
        int max = numbers[0];

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
            min = Math.Min(min, numbers[i]);
            max = Math.Max(max, numbers[i]);
        }

        double average = sum / numbers.Length;
        return new double[] { average, min, max };
    }
}
