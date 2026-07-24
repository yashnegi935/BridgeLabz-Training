namespace CalculatorProblems;

public class PowerCalculation
{
    public static void Run()
    {
        Console.Write("Enter Base: ");
        double number = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Power: ");
        double power = Convert.ToDouble(Console.ReadLine());

        double answer = Math.Pow(number, power);

        Console.WriteLine("Answer = " + answer);
    }
}