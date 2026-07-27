namespace CalculatorProblems;

public class TrigonometricCalculator
{
    public static void Run()
    {
        Console.Write("Enter angle in degrees: ");
        double angle = Convert.ToDouble(Console.ReadLine());

        double[] trigs = CalculateTrigonometricFunctions(angle);

        Console.WriteLine($"Sine: {trigs[0]}");
        Console.WriteLine($"Cosine: {trigs[1]}");
        Console.WriteLine($"Tangent: {trigs[2]}");
    }

    public static double[] CalculateTrigonometricFunctions(double angle)
    {
        double radians = angle * (Math.PI / 180.0);

        double sin = Math.Sin(radians);
        double cos = Math.Cos(radians);
        double tan = Math.Tan(radians);

        return new double[] { sin, cos, tan };
    }
}
