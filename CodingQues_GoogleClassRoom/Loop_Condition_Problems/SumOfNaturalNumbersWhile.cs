namespace CalculatorProblems;

public class SumOfNaturalNumbersWhile
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
        {
            int formulaSum = number * (number + 1) / 2;
            int loopSum = 0;
            int counter = 1;

            while (counter <= number)
            {
                loopSum += counter;
                counter++;
            }

            Console.WriteLine($"Sum using formula: {formulaSum}");
            Console.WriteLine($"Sum using while loop: {loopSum}");

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
