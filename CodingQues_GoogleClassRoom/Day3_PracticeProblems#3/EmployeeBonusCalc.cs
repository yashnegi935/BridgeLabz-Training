namespace CalculatorProblems;

public class EmployeeBonusCalc
{
    public static void Run()
    {
        double[,] empData = GenerateEmployeeData();
        double[,] bonusData = CalculateBonusAndNewSalary(empData);
        DisplaySummary(empData, bonusData);
    }

    public static double[,] GenerateEmployeeData()
    {
        Random random = new Random();
        double[,] data = new double[10, 2];
        for (int i = 0; i < 10; i++)
        {
            data[i, 0] = random.Next(10000, 100000);
            data[i, 1] = random.Next(1, 15);
        }
        return data;
    }

    public static double[,] CalculateBonusAndNewSalary(double[,] empData)
    {
        double[,] result = new double[10, 2];
        for (int i = 0; i < 10; i++)
        {
            double oldSalary = empData[i, 0];
            double serviceYears = empData[i, 1];
            double bonusRate = (serviceYears > 5) ? 0.05 : 0.02;
            double bonus = oldSalary * bonusRate;
            double newSalary = oldSalary + bonus;

            result[i, 0] = Math.Round(newSalary, 2);
            result[i, 1] = Math.Round(bonus, 2);
        }
        return result;
    }

    public static void DisplaySummary(double[,] empData, double[,] bonusData)
    {
        double totalOldSalary = 0;
        double totalNewSalary = 0;
        double totalBonus = 0;

        Console.WriteLine("Emp#\tOld Salary\tService(Yrs)\tBonus\t\tNew Salary");
        Console.WriteLine("------------------------------------------------------------------");
        for (int i = 0; i < 10; i++)
        {
            double oldSalary = empData[i, 0];
            double serviceYears = empData[i, 1];
            double newSalary = bonusData[i, 0];
            double bonus = bonusData[i, 1];

            totalOldSalary += oldSalary;
            totalNewSalary += newSalary;
            totalBonus += bonus;

            Console.WriteLine($"{i + 1}\t{oldSalary:F2}\t{serviceYears}\t\t{bonus:F2}\t\t{newSalary:F2}");
        }
        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine($"Total\t{totalOldSalary:F2}\t\t\t{totalBonus:F2}\t\t{totalNewSalary:F2}");
    }
}
