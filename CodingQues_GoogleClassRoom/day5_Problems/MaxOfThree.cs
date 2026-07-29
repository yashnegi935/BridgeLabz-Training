namespace CalculatorProblems;

public class MaxOfThree
{
    public static void Run()
    {
        int num1 = GetIntegerInput("Enter first number: ");
        int num2 = GetIntegerInput("Enter second number: ");
        int num3 = GetIntegerInput("Enter third number: ");

        int max = FindMaximum(num1, num2, num3);

        Console.WriteLine($"The maximum of {num1}, {num2}, and {num3} is: {max}");
    }

    private static int GetIntegerInput(string prompt)
    {
        int result;
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            if (int.TryParse(input, out result))
            {
                return result;
            }
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    private static int FindMaximum(int a, int b, int c)
    {
        return Math.Max(a, Math.Max(b, c));
    }
}
