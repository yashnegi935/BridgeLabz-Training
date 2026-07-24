namespace CalculatorProblems;

public class AverageOfThreeNumbers
{
    public static void Run()
    {
        Console.Write("Enter First Number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Third Number: ");
        double num3 = Convert.ToDouble(Console.ReadLine());

        double average = (num1 + num2 + num3) / 3;

        Console.WriteLine("Average = " + average);
    }
}