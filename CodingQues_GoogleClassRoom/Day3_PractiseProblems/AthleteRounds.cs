namespace CalculatorProblems;

public class AthleteRounds
{
    public static void Run()
    {
        Console.Write("Enter side 1 of triangle (in meters): ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 2 of triangle (in meters): ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 3 of triangle (in meters): ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        double totalRounds = CalculateRounds(side1, side2, side3);

        Console.WriteLine($"The athlete needs to complete {totalRounds} rounds to complete 5 km run.");
    }

    public static double CalculateRounds(double side1, double side2, double side3)
    {
        double distanceMeters = 5000;
        double perimeter = side1 + side2 + side3;
        return distanceMeters / perimeter;
    }
}
