namespace CalculatorProblems;

public class AreaOfCircle
{
    public static void Run()
    {
        Console.Write("Enter Radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        double area = Math.PI * radius * radius;

        Console.WriteLine("Area = " + area);
    }
}