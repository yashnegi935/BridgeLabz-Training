namespace CalculatorProblems;

public class CelsiusToFahrenheit
{
    public static void Run()
    {
        Console.Write("Enter Temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine("Temperature in Fahrenheit = " + fahrenheit);
    }
}