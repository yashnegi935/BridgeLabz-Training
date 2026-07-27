namespace CalculatorProblems;

public class SpringSeasonCheck
{
    public static void Run()
    {
        Console.Write("Enter month (1-12): ");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter day (1-31): ");
        int day = Convert.ToInt32(Console.ReadLine());

        bool isSpring = IsSpringSeason(month, day);

        if (isSpring)
        {
            Console.WriteLine("Its a Spring Season");
        }
        else
        {
            Console.WriteLine("Not a Spring Season");
        }
    }

    public static bool IsSpringSeason(int month, int day)
    {
        if ((month == 3 && day >= 20 && day <= 31) ||
            (month == 4 && day >= 1 && day <= 30) ||
            (month == 5 && day >= 1 && day <= 31) ||
            (month == 6 && day >= 1 && day <= 20))
        {
            return true;
        }
        return false;
    }
}
