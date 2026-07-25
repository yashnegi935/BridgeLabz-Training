namespace CalculatorProblems;

public class RocketLaunchFor
{
    public static void Run()
    {
        Console.Write("Enter countdown starting number: ");
        int counter = Convert.ToInt32(Console.ReadLine());

        for (int i = counter; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
    }
}
