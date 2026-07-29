namespace CalculatorProblems;

public class ModularCalculator
{
    public static void Run()
    {
        Console.WriteLine("Basic Modular Calculator");
        Console.WriteLine("1. Addition (+)");
        Console.WriteLine("2. Subtraction (-)");
        Console.WriteLine("3. Multiplication (*)");
        Console.WriteLine("4. Division (/)");
        Console.Write("Select operation (1-4): ");
        string? choice = Console.ReadLine();

        Console.Write("Enter first number: ");
        string? input1 = Console.ReadLine();

        Console.Write("Enter second number: ");
        string? input2 = Console.ReadLine();

        if (double.TryParse(input1, out double num1) && double.TryParse(input2, out double num2))
        {
            switch (choice)
            {
                case "1":
                    Console.WriteLine($"Result: {num1} + {num2} = {Add(num1, num2)}");
                    break;
                case "2":
                    Console.WriteLine($"Result: {num1} - {num2} = {Subtract(num1, num2)}");
                    break;
                case "3":
                    Console.WriteLine($"Result: {num1} * {num2} = {Multiply(num1, num2)}");
                    break;
                case "4":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    else
                    {
                        Console.WriteLine($"Result: {num1} / {num2} = {Divide(num1, num2)}");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation selected.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid number input.");
        }
    }

    private static double Add(double a, double b)
    {
        return a + b;
    }

    private static double Subtract(double a, double b)
    {
        return a - b;
    }

    private static double Multiply(double a, double b)
    {
        return a * b;
    }

    private static double Divide(double a, double b)
    {
        return a / b;
    }
}
