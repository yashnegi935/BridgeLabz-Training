namespace CalculatorProblems;

public class TemperatureConverter
{
    public static void Run()
    {
        Console.WriteLine("Temperature Converter");
        Console.WriteLine("1. Fahrenheit to Celsius");
        Console.WriteLine("2. Celsius to Fahrenheit");
        Console.Write("Choose conversion type (1 or 2): ");
        string? choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.Write("Enter temperature in Fahrenheit: ");
            if (double.TryParse(Console.ReadLine(), out double fahrenheit))
            {
                double celsius = FahrenheitToCelsius(fahrenheit);
                Console.WriteLine($"{fahrenheit}°F = {celsius:F2}°C");
            }
            else
            {
                Console.WriteLine("Invalid temperature value.");
            }
        }
        else if (choice == "2")
        {
            Console.Write("Enter temperature in Celsius: ");
            if (double.TryParse(Console.ReadLine(), out double celsius))
            {
                double fahrenheit = CelsiusToFahrenheit(celsius);
                Console.WriteLine($"{celsius}°C = {fahrenheit:F2}°F");
            }
            else
            {
                Console.WriteLine("Invalid temperature value.");
            }
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    private static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    private static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
}
