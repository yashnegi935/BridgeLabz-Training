namespace CalculatorProblems;

public class QuadraticRoots
{
    public static void Run()
    {
        Console.Write("Enter coefficient a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter coefficient b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter coefficient c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double[] roots = FindQuadraticRoots(a, b, c);

        if (roots.Length == 2)
        {
            Console.WriteLine($"Two distinct roots: x1 = {roots[0]}, x2 = {roots[1]}");
        }
        else if (roots.Length == 1)
        {
            Console.WriteLine($"One root: x = {roots[0]}");
        }
        else
        {
            Console.WriteLine("No real roots exist (delta is negative).");
        }
    }

    public static double[] FindQuadraticRoots(double a, double b, double c)
    {
        double delta = (b * b) - (4 * a * c);

        if (delta > 0)
        {
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return new double[] { root1, root2 };
        }
        else if (delta == 0)
        {
            double root = -b / (2 * a);
            return new double[] { root };
        }
        else
        {
            return new double[0];
        }
    }
}
