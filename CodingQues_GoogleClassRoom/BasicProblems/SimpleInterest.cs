namespace CalculatorProblems;

public class SimpleInterest
{
    public static void Run()
    {
        Console.Write("Enter Principal: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time: ");
        double time = Convert.ToDouble(Console.ReadLine());

        double interest = (principal * rate * time) / 100;

        Console.WriteLine("Simple Interest = " + interest);
    }
}