namespace CalculatorProblems;

public class YoungestAndTallestFriend
{
    public static void Run()
    {
        Console.Write("Enter Amar's age: ");
        int amarAge = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Amar's height in cm: ");
        double amarHeight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Akbar's age: ");
        int akbarAge = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Akbar's height in cm: ");
        double akbarHeight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Anthony's age: ");
        int anthonyAge = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Anthony's height in cm: ");
        double anthonyHeight = Convert.ToDouble(Console.ReadLine());

        if (amarAge <= akbarAge && amarAge <= anthonyAge)
        {
            Console.WriteLine("Youngest friend: Amar");
        }
        else if (akbarAge <= amarAge && akbarAge <= anthonyAge)
        {
            Console.WriteLine("Youngest friend: Akbar");
        }
        else
        {
            Console.WriteLine("Youngest friend: Anthony");
        }

        if (amarHeight >= akbarHeight && amarHeight >= anthonyHeight)
        {
            Console.WriteLine("Tallest friend: Amar");
        }
        else if (akbarHeight >= amarHeight && akbarHeight >= anthonyHeight)
        {
            Console.WriteLine("Tallest friend: Akbar");
        }
        else
        {
            Console.WriteLine("Tallest friend: Anthony");
        }
    }
}
