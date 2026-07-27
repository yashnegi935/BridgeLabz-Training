namespace CalculatorProblems;

public class EuclideanDistance
{
    public static void Run()
    {
        double x1 = 2, y1 = 3;
        double x2 = 6, y2 = 7;

        double distance = CalculateDistance(x1, y1, x2, y2);
        double[] lineEquation = CalculateLineEquation(x1, y1, x2, y2);

        Console.WriteLine($"Point 1: ({x1}, {y1})");
        Console.WriteLine($"Point 2: ({x2}, {y2})");
        Console.WriteLine($"Euclidean Distance: {distance:F4}");
        Console.WriteLine($"Slope (m): {lineEquation[0]:F4}");
        Console.WriteLine($"Y-Intercept (b): {lineEquation[1]:F4}");
        Console.WriteLine($"Line Equation: y = {lineEquation[0]:F4}*x + {lineEquation[1]:F4}");
    }

    public static double CalculateDistance(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    public static double[] CalculateLineEquation(double x1, double y1, double x2, double y2)
    {
        double slope = (y2 - y1) / (x2 - x1);
        double yIntercept = y1 - slope * x1;
        return new double[] { slope, yIntercept };
    }
}
