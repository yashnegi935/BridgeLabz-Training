namespace CalculatorProblems;

public class RocketLaunchWhile
{
    public static void Run()
    {
        Console.Write("Enter countdown starting number: ");
        int counter = Convert.ToInt32(Console.ReadLine());

        while (counter >= 1)
        {
            Console.WriteLine(counter);
            counter--;
        }
    }
}
