namespace CalculatorProblems;

public class VolumeOfCylinder
{
    public static void Run()
    {
        Console.Write("Enter Radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Height: ");
        double height = Convert.ToDouble(Console.ReadLine());

        double volume = Math.PI * radius * radius * height;

        Console.WriteLine("Volume = " + volume);
    }
}