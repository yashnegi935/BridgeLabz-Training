namespace CalculatorProblems;

public class BMICalculator
{
    public static void Run()
    {
        Console.Write("Enter weight in kg: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter height in cm: ");
        double heightCm = Convert.ToDouble(Console.ReadLine());

        double heightMeter = heightCm / 100;
        double bmi = weight / (heightMeter * heightMeter);

        Console.WriteLine($"BMI = {bmi:F2}");

        if (bmi < 18.5)
        {
            Console.WriteLine("Weight Status: Underweight");
        }
        else if (bmi >= 18.5 && bmi <= 24.9)
        {
            Console.WriteLine("Weight Status: Normal weight");
        }
        else if (bmi >= 25.0 && bmi <= 29.9)
        {
            Console.WriteLine("Weight Status: Overweight");
        }
        else
        {
            Console.WriteLine("Weight Status: Obese");
        }
    }
}
