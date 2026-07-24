namespace CalculatorProblems;

public class EarthVolume
{
    public static void Run()
    {
        double radius = 6378;

        double volumeKm = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        double volumeMiles = volumeKm / Math.Pow(1.6, 3);

        Console.WriteLine("The volume of earth in cubic kilometers is " + volumeKm);
        Console.WriteLine("The volume of earth in cubic miles is " + volumeMiles);
    }
}