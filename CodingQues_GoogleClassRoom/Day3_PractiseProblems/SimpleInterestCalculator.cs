namespace CalculatorProblems;

public class SimpleInterestCalculator
{
    public static void Run()
    {
        Console.Write("Enter Principal: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate of Interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time: ");
        double time = Convert.ToDouble(Console.ReadLine());

        double interest = CalculateSimpleInterest(principal, rate, time);

        Console.WriteLine($"The Simple Interest is {interest} for Principal {principal}, Rate of Interest {rate} and Time {time}");
    }

    public static double CalculateSimpleInterest(double principal, double rate, double time)
    {
        return (principal * rate * time) / 100;
    }
}
