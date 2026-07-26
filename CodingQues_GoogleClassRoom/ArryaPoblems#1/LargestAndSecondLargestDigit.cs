namespace CalculatorProblems;

public class LargestAndSecondLargestDigit
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int temp = Math.Abs(number);

        int maxDigit = 10;
        int[] digits = new int[maxDigit];
        int index = 0;

        if (temp == 0)
        {
            digits[index] = 0;
            index++;
        }

        while (temp != 0)
        {
            if (index == maxDigit)
            {
                break;
            }

            digits[index] = temp % 10;
            temp /= 10;
            index++;
        }

        int largest = -1;
        int secondLargest = -1;

        for (int i = 0; i < index; i++)
        {
            int current = digits[i];
            if (current > largest)
            {
                secondLargest = largest;
                largest = current;
            }
            else if (current > secondLargest && current != largest)
            {
                secondLargest = current;
            }
        }

        Console.WriteLine($"Largest digit: {largest}");
        Console.WriteLine($"Second largest digit: {secondLargest}");
    }
}
