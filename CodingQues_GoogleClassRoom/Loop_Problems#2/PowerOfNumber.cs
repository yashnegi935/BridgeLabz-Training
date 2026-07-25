namespace CalculatorProblems;

public class PowerOfNumber
{
    public static void Run()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter power: ");
        int power = Convert.ToInt32(Console.ReadLine());

        long result = 1;

        for (int i = 1; i <= power; i++)
        {
            result *= number;
        }

        Console.WriteLine($"{number}^{power} = {result}");
    }
}
