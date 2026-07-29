namespace CalculatorProblems;

public class GcdLcmCalculator
{
    public static void Run()
    {
        Console.Write("Enter first number: ");
        string? input1 = Console.ReadLine();

        Console.Write("Enter second number: ");
        string? input2 = Console.ReadLine();

        if (long.TryParse(input1, out long num1) && long.TryParse(input2, out long num2) && num1 > 0 && num2 > 0)
        {
            long gcd = CalculateGCD(num1, num2);
            long lcm = CalculateLCM(num1, num2, gcd);

            Console.WriteLine($"Greatest Common Divisor (GCD) of {num1} and {num2}: {gcd}");
            Console.WriteLine($"Least Common Multiple (LCM) of {num1} and {num2}: {lcm}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter positive integers.");
        }
    }

    private static long CalculateGCD(long a, long b)
    {
        while (b != 0)
        {
            long temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    private static long CalculateLCM(long a, long b, long gcd)
    {
        return (a / gcd) * b;
    }
}
