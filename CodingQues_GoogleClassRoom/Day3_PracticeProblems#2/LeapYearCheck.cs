namespace CalculatorProblems;

public class LeapYearCheck
{
    public static void Run()
    {
        Console.Write("Enter a year (>= 1582): ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year < 1582)
        {
            Console.WriteLine("Year must be 1582 or later for Gregorian calendar.");
            return;
        }

        bool isLeap = IsLeapYear(year);

        if (isLeap)
        {
            Console.WriteLine($"{year} is a Leap Year.");
        }
        else
        {
            Console.WriteLine($"{year} is Not a Leap Year.");
        }
    }

    public static bool IsLeapYear(int year)
    {
        if (year < 1582)
        {
            return false;
        }

        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}
