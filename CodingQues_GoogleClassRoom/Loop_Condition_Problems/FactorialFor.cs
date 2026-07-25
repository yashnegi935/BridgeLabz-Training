namespace CalculatorProblems;

public class FactorialFor
{
    public static void Run()
    {
        Console.Write("Enter a positive integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
        {
            long factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"Factorial of {number} is {factorial}");
        }
        else
        {
            Console.WriteLine("Please enter a natural number");
        }
    }
}
