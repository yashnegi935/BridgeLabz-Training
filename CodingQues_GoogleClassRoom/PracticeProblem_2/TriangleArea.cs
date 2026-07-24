namespace CalculatorProblems;

public class TriangleArea
{
    public static void Run()
    {
        Console.Write("Enter Base: ");
        double baseValue = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Height: ");
        double height = Convert.ToDouble(Console.ReadLine());

        double area = 0.5 * baseValue * height;

        Console.WriteLine("Area of Triangle = " + area);
    }
}