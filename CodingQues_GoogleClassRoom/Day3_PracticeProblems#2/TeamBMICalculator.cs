namespace CalculatorProblems;

public class TeamBMICalculator
{
    public static void Run()
    {
        double[,] teamData = new double[10, 3];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter weight (in kg) for person {i + 1}: ");
            teamData[i, 0] = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Enter height (in cm) for person {i + 1}: ");
            teamData[i, 1] = Convert.ToDouble(Console.ReadLine());
        }

        teamData = CalculateBMI(teamData);
        string[] statuses = DetermineBMIStatus(teamData);

        Console.WriteLine("\nPerson\tWeight(kg)\tHeight(cm)\tBMI\t\tStatus");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{i + 1}\t{teamData[i, 0]}\t\t{teamData[i, 1]}\t\t{Math.Round(teamData[i, 2], 2)}\t\t{statuses[i]}");
        }
    }

    public static double[,] CalculateBMI(double[,] data)
    {
        int rows = data.GetLength(0);
        for (int i = 0; i < rows; i++)
        {
            double weight = data[i, 0];
            double heightM = data[i, 1] / 100.0;
            data[i, 2] = weight / (heightM * heightM);
        }
        return data;
    }

    public static string[] DetermineBMIStatus(double[,] data)
    {
        int rows = data.GetLength(0);
        string[] statuses = new string[rows];

        for (int i = 0; i < rows; i++)
        {
            double bmi = data[i, 2];
            if (bmi < 18.5)
            {
                statuses[i] = "Underweight";
            }
            else if (bmi <= 24.9)
            {
                statuses[i] = "Normal weight";
            }
            else if (bmi <= 29.9)
            {
                statuses[i] = "Overweight";
            }
            else
            {
                statuses[i] = "Obese";
            }
        }
        return statuses;
    }
}
