namespace CalculatorProblems;

public class SquareSide
{
    public static void Run()
    {
        Console.Write("Enter Perimeter: ");
        double perimeter = Convert.ToDouble(Console.ReadLine());

        double side = perimeter / 4;

        Console.WriteLine("The length of the side is " + side + " whose perimeter is " + perimeter);
    }
}