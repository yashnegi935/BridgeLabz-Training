namespace CalculatorProblems;

public class NumberCheckerQ6
{
    public static void Run()
    {
        int number = 145;
        int[] factors = NumberChecker.FindFactors(number);
        int greatestFactor = NumberChecker.FindGreatestFactor(factors);
        int sumFactors = NumberChecker.FindSumOfFactors(factors);
        long productFactors = NumberChecker.FindProductOfFactors(factors);
        double productCubes = NumberChecker.FindProductOfCubeOfFactors(factors);
        bool isPerfect = NumberChecker.IsPerfectNumber(number);
        bool isAbundant = NumberChecker.IsAbundantNumber(number);
        bool isDeficient = NumberChecker.IsDeficientNumber(number);
        bool isStrong = NumberChecker.IsStrongNumber(number);

        Console.WriteLine($"Number: {number}");
        Console.Write("Factors: ");
        for (int i = 0; i < factors.Length; i++)
        {
            Console.Write(factors[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine($"Greatest Factor: {greatestFactor}");
        Console.WriteLine($"Sum of Factors: {sumFactors}");
        Console.WriteLine($"Product of Factors: {productFactors}");
        Console.WriteLine($"Product of Cubes of Factors: {productCubes:E}");
        Console.WriteLine($"Is Perfect Number: {isPerfect}");
        Console.WriteLine($"Is Abundant Number: {isAbundant}");
        Console.WriteLine($"Is Deficient Number: {isDeficient}");
        Console.WriteLine($"Is Strong Number: {isStrong}");
    }
}
