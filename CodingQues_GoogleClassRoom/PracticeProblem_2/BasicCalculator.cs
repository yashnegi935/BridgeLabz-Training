namespace CalculatorProblems;

public class BasicCalculator
{
    public static void Run()
    {
        Console.Write("Enter First Number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        double addition = number1 + number2;
        double subtraction = number1 - number2;
        double multiplication = number1 * number2;
        double division = number1 / number2;

        Console.WriteLine("Addition = " + addition);
        Console.WriteLine("Subtraction = " + subtraction);
        Console.WriteLine("Multiplication = " + multiplication);
        Console.WriteLine("Division = " + division);
    }
}