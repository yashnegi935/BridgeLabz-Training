namespace CalculatorProblems;

public class UserKilometerToMiles
{
    public static void Run()
    {
        Console.Write("Enter distance in kilometer: ");
        double kilometer = Convert.ToDouble(Console.ReadLine());

        double miles = kilometer / 1.6;

        Console.WriteLine("The total miles is " + miles + " mile for the given " + kilometer + " km");
    }
}