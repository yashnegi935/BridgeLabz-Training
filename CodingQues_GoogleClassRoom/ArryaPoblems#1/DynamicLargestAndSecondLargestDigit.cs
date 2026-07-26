namespace CalculatorProblems;

public class DynamicLargestAndSecondLargestDigit
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        long number = Convert.ToInt64(Console.ReadLine());

        long tempNumber = Math.Abs(number);

        int maxDigit = 10;
        int[] digits = new int[maxDigit];
        int index = 0;

        if (tempNumber == 0)
        {
            digits[index] = 0;
            index++;
        }

        while (tempNumber != 0)
        {
            if (index == maxDigit)
            {
                break;
            }

            digits[index] = (int)(tempNumber % 10);
            tempNumber /= 10;
            index++;
        }

        int largest = -1;
        int secondLargest = -1;

        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i];
            }
        }

        Console.WriteLine($"Largest digit: {largest}");

        if (secondLargest == -1)
        {
            Console.WriteLine("Second largest digit does not exist.");
        }
        else
        {
            Console.WriteLine($"Second largest digit: {secondLargest}");
        }
    }
}