namespace CalculatorProblems;

public class HeightConverter
{
    public static void Run()
    {
        Console.Write("Enter Height in cm: ");
        double centimeter = Convert.ToDouble(Console.ReadLine());

        double totalInches = centimeter / 2.54;
        int feet = (int)(totalInches / 12);
        double inches = totalInches % 12;

        Console.WriteLine("Your Height in cm is " + centimeter + " while in feet is " + feet + " and inches is " + inches);
    }
}