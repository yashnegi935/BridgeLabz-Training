namespace CalculatorProblems;

public class CollinearPoints
{
    public static void Run()
    {
        double x1 = 2, y1 = 4;
        double x2 = 4, y2 = 6;
        double x3 = 6, y3 = 8;

        bool collinearSlope = IsCollinearBySlope(x1, y1, x2, y2, x3, y3);
        bool collinearArea = IsCollinearByArea(x1, y1, x2, y2, x3, y3);

        Console.WriteLine($"Points: A({x1},{y1}), B({x2},{y2}), C({x3},{y3})");
        Console.WriteLine($"Collinear by Slope Formula: {collinearSlope}");
        Console.WriteLine($"Collinear by Triangle Area Formula: {collinearArea}");
    }

    public static bool IsCollinearBySlope(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        double slopeAB = (y2 - y1) / (x2 - x1);
        double slopeBC = (y3 - y2) / (x3 - x2);
        double slopeAC = (y3 - y1) / (x3 - x1);

        return Math.Abs(slopeAB - slopeBC) < 1e-9 && Math.Abs(slopeBC - slopeAC) < 1e-9;
    }

    public static bool IsCollinearByArea(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
        return Math.Abs(area) < 1e-9;
    }
}
