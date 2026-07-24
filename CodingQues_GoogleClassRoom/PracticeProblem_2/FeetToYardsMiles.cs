namespace CalculatorProblems;

public class FeetToYardsMiles
{
    public static void Run()
    {
        Console.Write("Enter Distance in Feet: ");
        double feet = Convert.ToDouble(Console.ReadLine());

        double yards = feet / 3;
        double miles = yards / 1760;

        Console.WriteLine("Distance in yards is " + yards);
        Console.WriteLine("Distance in miles is " + miles);
    }
}