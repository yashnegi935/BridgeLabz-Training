namespace CalculatorProblems;

public class FizzBuzzArray
{
    public static void Run()
    {
        Console.Write("Enter a positive integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        string[] results = new string[number + 1];

        for (int i = 0; i <= number; i++)
        {
            if (i == 0)
            {
                results[i] = "0";
            }
            else if (i % 3 == 0 && i % 5 == 0)
            {
                results[i] = "FizzBuzz";
            }
            else if (i % 3 == 0)
            {
                results[i] = "Fizz";
            }
            else if (i % 5 == 0)
            {
                results[i] = "Buzz";
            }
            else
            {
                results[i] = i.ToString();
            }
        }

        for (int i = 0; i <= number; i++)
        {
            Console.WriteLine($"Position {i} = {results[i]}");
        }
    }
}
