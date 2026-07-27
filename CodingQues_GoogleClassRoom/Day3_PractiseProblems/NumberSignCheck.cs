namespace CalculatorProblems;

public class NumberSignCheck
{
    public static void Run()
    {
        Console.Write("Enter an integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int result = CheckNumber(number);

        if (result == 1)
        {
            Console.WriteLine("The number is Positive.");
        }
        else if (result == -1)
        {
            Console.WriteLine("The number is Negative.");
        }
        else
        {
            Console.WriteLine("The number is Zero.");
        }
    }

    public static int CheckNumber(int number)
    {
        if (number > 0)
        {
            return 1;
        }
        else if (number < 0)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
}
