namespace CalculatorProblems;

public class PrimeChecker
{
    public static void Run()
    {
        Console.Write("Enter a number to check if it is prime: ");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            bool result = IsPrime(number);
            if (result)
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is NOT a prime number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    private static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
