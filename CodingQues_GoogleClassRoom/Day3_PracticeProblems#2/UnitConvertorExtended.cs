namespace CalculatorProblems;

public class UnitConvertorExtended
{
    public static void Run()
    {
        Console.Write("Enter Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{fahrenheit} F = {ConvertFahrenheitToCelsius(fahrenheit)} C");

        Console.Write("Enter Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{celsius} C = {ConvertCelsiusToFahrenheit(celsius)} F");

        Console.Write("Enter Pounds: ");
        double pounds = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{pounds} lbs = {ConvertPoundsToKilograms(pounds)} kg");

        Console.Write("Enter Kilograms: ");
        double kg = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{kg} kg = {ConvertKilogramsToPounds(kg)} lbs");

        Console.Write("Enter Gallons: ");
        double gallons = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{gallons} gallons = {ConvertGallonsToLiters(gallons)} liters");

        Console.Write("Enter Liters: ");
        double liters = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{liters} liters = {ConvertLitersToGallons(liters)} gallons");
    }

    public static double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    public static double ConvertCelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    public static double ConvertPoundsToKilograms(double pounds)
    {
        double pounds2kilograms = 0.453592;
        return pounds * pounds2kilograms;
    }

    public static double ConvertKilogramsToPounds(double kilograms)
    {
        double kilograms2pounds = 2.20462;
        return kilograms * kilograms2pounds;
    }

    public static double ConvertGallonsToLiters(double gallons)
    {
        double gallons2liters = 3.78541;
        return gallons * gallons2liters;
    }

    public static double ConvertLitersToGallons(double liters)
    {
        double liters2gallons = 0.264172;
        return liters * liters2gallons;
    }
}
