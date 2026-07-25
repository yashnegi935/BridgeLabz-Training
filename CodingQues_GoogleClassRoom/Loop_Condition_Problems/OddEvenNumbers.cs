namespace CalculatorProblems;

public class OddEvenNumbers
{
    public static void Run()
    {
        Console.Write("Enter a natural number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
        {
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} is Even");
                }
                else
                {
                    Console.WriteLine($"{i} is Odd");
                }
            }
        }
        else
        {
            Console.WriteLine($"The number {number} is not a natural number");
        }
    }
}
