namespace CalculatorProblems;

public class PersonBMI2DArray
{
    public static void Run()
    {
        Console.Write("Enter number of persons: ");
        int number = Convert.ToInt32(Console.ReadLine());

        double[,] personData = new double[number, 3];
        string[] weightStatus = new string[number];

        for (int i = 0; i < number; i++)
        {
            Console.WriteLine($"\nEnter details for Person {i + 1}:");
            Console.Write("Weight (in kg): ");
            double w = Convert.ToDouble(Console.ReadLine());

            Console.Write("Height (in meters): ");
            double h = Convert.ToDouble(Console.ReadLine());

            if (w <= 0 || h <= 0)
            {
                Console.WriteLine("Please enter positive values for weight and height.");
                i--;
                continue;
            }

            double calculatedBmi = w / (h * h);

            personData[i, 0] = w;
            personData[i, 1] = h;
            personData[i, 2] = calculatedBmi;

            if (calculatedBmi < 18.5)
            {
                weightStatus[i] = "Underweight";
            }
            else if (calculatedBmi <= 24.9)
            {
                weightStatus[i] = "Normal";
            }
            else if (calculatedBmi <= 29.9)
            {
                weightStatus[i] = "Overweight";
            }
            else
            {
                weightStatus[i] = "Obese";
            }
        }

        Console.WriteLine("\n--- BMI Results ---");
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine($"Person {i + 1}: Height = {personData[i, 1]}m, Weight = {personData[i, 0]}kg, BMI = {personData[i, 2]:F2}, Status = {weightStatus[i]}");
        }
    }
}
