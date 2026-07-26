namespace CalculatorProblems;

public class PersonBMICalculator
{
    public static void Run()
    {
        Console.Write("Enter number of persons: ");
        int number = Convert.ToInt32(Console.ReadLine());

        double[] weight = new double[number];
        double[] height = new double[number];
        double[] bmi = new double[number];
        string[] status = new string[number];

        for (int i = 0; i < number; i++)
        {
            Console.WriteLine($"\nEnter details for Person {i + 1}:");
            Console.Write("Weight (in kg): ");
            weight[i] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Height (in meters): ");
            height[i] = Convert.ToDouble(Console.ReadLine());

            if (weight[i] <= 0 || height[i] <= 0)
            {
                Console.WriteLine("Please enter positive values for weight and height.");
                i--;
                continue;
            }

            bmi[i] = weight[i] / (height[i] * height[i]);

            if (bmi[i] < 18.5)
            {
                status[i] = "Underweight";
            }
            else if (bmi[i] <= 24.9)
            {
                status[i] = "Normal";
            }
            else if (bmi[i] <= 29.9)
            {
                status[i] = "Overweight";
            }
            else
            {
                status[i] = "Obese";
            }
        }

        Console.WriteLine("\n--- BMI Results ---");
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine($"Person {i + 1}: Height = {height[i]}m, Weight = {weight[i]}kg, BMI = {bmi[i]:F2}, Status = {status[i]}");
        }
    }
}
