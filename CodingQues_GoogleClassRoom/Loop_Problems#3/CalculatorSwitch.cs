namespace CalculatorProblems;

public class CalculatorSwitch
{
    public static void Run()
    {
        Console.Write("Enter First Number: ");
        double first = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        double second = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Operator (+, -, *, /): ");
        string op = Console.ReadLine() ?? "";

        switch (op)
        {
            case "+":
                Console.WriteLine($"Result = {first + second}");
                break;
            case "-":
                Console.WriteLine($"Result = {first - second}");
                break;
            case "*":
                Console.WriteLine($"Result = {first * second}");
                break;
            case "/":
                if (second != 0)
                {
                    Console.WriteLine($"Result = {first / second}");
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero");
                }
                break;
            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
