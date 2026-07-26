namespace CalculatorProblems;

public class SumUntilZeroOrLimit
{
    public static void Run()
    {
        double[] numbers = new double[10];
        double total = 0.0;
        int index = 0;

        while (true)
        {
            if (index == 10)
            {
                break;
            }

            Console.Write("Enter a number (0 or negative to stop): ");
            double input = Convert.ToDouble(Console.ReadLine());

            if (input <= 0)
            {
                break;
            }

            numbers[index] = input;
            index++;
        }

        Console.WriteLine("\nEntered numbers:");
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(numbers[i]);
            total += numbers[i];
        }

        Console.WriteLine($"Total sum: {total}");
    }
}
