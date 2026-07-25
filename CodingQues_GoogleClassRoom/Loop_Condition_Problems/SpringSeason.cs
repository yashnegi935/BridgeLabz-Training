namespace CalculatorProblems;

public class SpringSeason
{
    public static void Run()
    {
        Console.Write("Enter Month: ");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Day: ");
        int day = Convert.ToInt32(Console.ReadLine());

        bool isSpring = (month == 3 && day >= 20 && day <= 31) ||
                        (month == 4 && day >= 1 && day <= 30) ||
                        (month == 5 && day >= 1 && day <= 31) ||
                        (month == 6 && day >= 1 && day <= 20);

        if (isSpring)
        {
            Console.WriteLine("Its a Spring Season");
        }
        else
        {
            Console.WriteLine("Not a Spring Season");
        }
    }
}
