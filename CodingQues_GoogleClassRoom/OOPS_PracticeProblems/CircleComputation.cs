namespace CalculatorProblems;

public class Circle
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double CalculateCircumference()
    {
        return 2 * Math.PI * Radius;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("\n--- Circle Details ---");
        Console.WriteLine($"Radius        : {Radius}");
        Console.WriteLine($"Area          : {CalculateArea():F2}");
        Console.WriteLine($"Circumference : {CalculateCircumference():F2}");
    }
}

public class CircleComputation
{
    public static void Run()
    {
        Console.Write("Enter Radius of Circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        Circle circle = new Circle(radius);
        circle.DisplayDetails();
    }
}
