namespace CalculatorProblems;

public class UnitConvertorDistance
{
    public static void Run()
    {
        Console.Write("Enter distance in kilometers: ");
        double km = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{km} km = {ConvertKmToMiles(km)} miles");

        Console.Write("Enter distance in miles: ");
        double miles = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{miles} miles = {ConvertMilesToKm(miles)} km");

        Console.Write("Enter distance in meters: ");
        double meters = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{meters} meters = {ConvertMetersToFeet(meters)} feet");

        Console.Write("Enter distance in feet: ");
        double feet = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{feet} feet = {ConvertFeetToMeters(feet)} meters");
    }

    public static double ConvertKmToMiles(double km)
    {
        double km2miles = 0.621371;
        return km * km2miles;
    }

    public static double ConvertMilesToKm(double miles)
    {
        double miles2km = 1.60934;
        return miles * miles2km;
    }

    public static double ConvertMetersToFeet(double meters)
    {
        double meters2feet = 3.28084;
        return meters * meters2feet;
    }

    public static double ConvertFeetToMeters(double feet)
    {
        double feet2meters = 0.3048;
        return feet * feet2meters;
    }
}
