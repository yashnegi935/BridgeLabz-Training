namespace CalculatorProblems;

public class RectanglePerimeter
{
    public static void Run()
    {
        Console.Write("Enter Length: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Width: ");
        double width = Convert.ToDouble(Console.ReadLine());

        double perimeter = 2 * (length + width);

        Console.WriteLine("Perimeter = " + perimeter);
    }
}