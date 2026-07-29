namespace CalculatorProblems;

public class NumberGuessingGame
{
    public static void Run()
    {
        Console.WriteLine("Think of a number between 1 and 100.");
        Console.WriteLine("Respond with 'high', 'low', or 'correct'.");

        int min = 1;
        int max = 100;
        bool isGuessed = false;

        while (!isGuessed && min <= max)
        {
            int guess = GenerateGuess(min, max);
            Console.WriteLine($"Computer guess: {guess}");

            string feedback = GetUserFeedback();

            if (feedback == "correct" || feedback == "c")
            {
                Console.WriteLine("Hooray! The computer guessed your number!");
                isGuessed = true;
            }
            else if (feedback == "high" || feedback == "h")
            {
                max = guess - 1;
            }
            else if (feedback == "low" || feedback == "l")
            {
                min = guess + 1;
            }
            else
            {
                Console.WriteLine("Invalid response. Please enter 'high', 'low', or 'correct'.");
            }
        }
    }

    private static int GenerateGuess(int min, int max)
    {
        return (min + max) / 2;
    }

    private static string GetUserFeedback()
    {
        Console.Write("Is the guess high, low, or correct? ");
        string? input = Console.ReadLine();
        return input != null ? input.Trim().ToLower() : "";
    }
}
