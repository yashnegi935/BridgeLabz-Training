namespace CalculatorProblems;

public class NumberArrayClassifier
{
    public static void Run()
    {
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            if (IsPositive(numbers[i]))
            {
                if (IsEven(numbers[i]))
                {
                    Console.WriteLine($"Number {numbers[i]} is Positive and Even.");
                }
                else
                {
                    Console.WriteLine($"Number {numbers[i]} is Positive and Odd.");
                }
            }
            else if (numbers[i] < 0)
            {
                Console.WriteLine($"Number {numbers[i]} is Negative.");
            }
            else
            {
                Console.WriteLine($"Number {numbers[i]} is Zero.");
            }
        }

        int comparison = Compare(numbers[0], numbers[numbers.Length - 1]);
        if (comparison == 1)
        {
            Console.WriteLine($"First element ({numbers[0]}) is Greater than last element ({numbers[numbers.Length - 1]}).");
        }
        else if (comparison == 0)
        {
            Console.WriteLine($"First element ({numbers[0]}) is Equal to last element ({numbers[numbers.Length - 1]}).");
        }
        else
        {
            Console.WriteLine($"First element ({numbers[0]}) is Less than last element ({numbers[numbers.Length - 1]}).");
        }
    }

    public static bool IsPositive(int number)
    {
        return number > 0;
    }

    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    public static int Compare(int number1, int number2)
    {
        if (number1 > number2)
        {
            return 1;
        }
        else if (number1 == number2)
        {
            return 0;
        }
        else
        {
            return -1;
        }
    }
}
