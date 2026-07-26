namespace CalculatorProblems;

public class DigitFrequency
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        long number = Convert.ToInt64(Console.ReadLine());
        long temp = Math.Abs(number);

        int count = 0;
        long t = temp;

        if (t == 0)
        {
            count = 1;
        }
        else
        {
            while (t > 0)
            {
                count++;
                t /= 10;
            }
        }

        int[] digits = new int[count];
        t = temp;

        if (t == 0)
        {
            digits[0] = 0;
        }
        else
        {
            for (int i = count - 1; i >= 0; i--)
            {
                digits[i] = (int)(t % 10);
                t /= 10;
            }
        }

        int[] frequency = new int[10];
        for (int i = 0; i < count; i++)
        {
            frequency[digits[i]]++;
        }

        Console.WriteLine("\nDigit Frequencies:");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i] > 0)
            {
                Console.WriteLine($"Digit {i}: {frequency[i]} time(s)");
            }
        }
    }
}
