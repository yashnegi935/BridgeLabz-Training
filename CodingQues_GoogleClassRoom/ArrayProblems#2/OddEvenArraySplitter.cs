namespace CalculatorProblems;

public class OddEvenArraySplitter
{
    public static void Run()
    {
        Console.Write("Enter a natural number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Error: Please enter a positive natural number.");
            return;
        }

        int arraySize = number / 2 + 1;
        int[] evenNumbers = new int[arraySize];
        int[] oddNumbers = new int[arraySize];

        int evenIndex = 0;
        int oddIndex = 0;

        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                evenNumbers[evenIndex] = i;
                evenIndex++;
            }
            else
            {
                oddNumbers[oddIndex] = i;
                oddIndex++;
            }
        }

        Console.Write("Even numbers: ");
        for (int i = 0; i < evenIndex; i++)
        {
            Console.Write(evenNumbers[i] + " ");
        }
        Console.WriteLine();

        Console.Write("Odd numbers: ");
        for (int i = 0; i < oddIndex; i++)
        {
            Console.Write(oddNumbers[i] + " ");
        }
        Console.WriteLine();
    }
}
