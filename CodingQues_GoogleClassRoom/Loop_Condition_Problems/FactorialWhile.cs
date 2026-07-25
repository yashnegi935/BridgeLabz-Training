namespace CalculatorProblems;

public class FactorialWhile
{
    public static void Run()
    {
        Console.Write("Enter a positive integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
        {
            long factorial = 1;
            int counter = 1;

            while (counter <= number)
            {
                factorial *= counter;
                counter++;
            }

            Console.WriteLine($"Factorial of {number} is {factorial}");
        }
        else
        {
            Console.WriteLine("Please enter a positive integer");
        }
    }
}
