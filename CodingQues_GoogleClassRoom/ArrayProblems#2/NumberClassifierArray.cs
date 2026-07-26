namespace CalculatorProblems;

public class NumberClassifierArray
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
            int num = numbers[i];
            if (num > 0)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine($"{num} is Positive and Even");
                }
                else
                {
                    Console.WriteLine($"{num} is Positive and Odd");
                }
            }
            else if (num < 0)
            {
                Console.WriteLine($"{num} is Negative");
            }
            else
            {
                Console.WriteLine($"{num} is Zero");
            }
        }

        int first = numbers[0];
        int last = numbers[numbers.Length - 1];

        if (first == last)
        {
            Console.WriteLine($"First element ({first}) and last element ({last}) are Equal.");
        }
        else if (first > last)
        {
            Console.WriteLine($"First element ({first}) is Greater than last element ({last}).");
        }
        else
        {
            Console.WriteLine($"First element ({first}) is Less than last element ({last}).");
        }
    }
}
