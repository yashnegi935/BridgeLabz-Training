namespace CalculatorProblems;

public class SumOfNaturalNumbersFor
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
        {
            int formulaSum = number * (number + 1) / 2;
            int loopSum = 0;

            for (int i = 1; i <= number; i++)
            {
                loopSum += i;
            }

            Console.WriteLine($"Sum using formula: {formulaSum}");
            Console.WriteLine($"Sum using for loop: {loopSum}");

            if (formulaSum == loopSum)
            {
                Console.WriteLine("Both computations are correct and match!");
            }
        }
        else
        {
            Console.WriteLine($"The number {number} is not a natural number");
        }
    }
}
