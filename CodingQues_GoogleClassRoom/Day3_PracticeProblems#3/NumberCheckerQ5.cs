namespace CalculatorProblems;

public class NumberCheckerQ5
{
    public static void Run()
    {
        int number = 25;
        bool isPrime = NumberChecker.IsPrime(number);
        bool isNeon = NumberChecker.IsNeonNumber(number);
        bool isSpy = NumberChecker.IsSpyNumber(number);
        bool isAutomorphic = NumberChecker.IsAutomorphicNumber(number);
        bool isBuzz = NumberChecker.IsBuzzNumber(number);

        Console.WriteLine($"Number: {number}");
        Console.WriteLine($"Is Prime Number: {isPrime}");
        Console.WriteLine($"Is Neon Number: {isNeon}");
        Console.WriteLine($"Is Spy Number: {isSpy}");
        Console.WriteLine($"Is Automorphic Number: {isAutomorphic}");
        Console.WriteLine($"Is Buzz Number: {isBuzz}");
    }
}
