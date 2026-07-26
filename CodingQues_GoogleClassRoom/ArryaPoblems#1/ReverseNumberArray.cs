namespace CalculatorProblems;

public class ReverseNumberArray
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

        int[] reversedDigits = new int[count];
        for (int i = 0; i < count; i++)
        {
            reversedDigits[i] = digits[count - 1 - i];
        }

        Console.Write("Reversed number: ");
        for (int i = 0; i < count; i++)
        {
            Console.Write(reversedDigits[i]);
        }
        Console.WriteLine();
    }
}
