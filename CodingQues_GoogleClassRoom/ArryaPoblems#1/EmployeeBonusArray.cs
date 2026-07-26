namespace CalculatorProblems;

public class EmployeeBonusArray
{
    public static void Run()
    {
        double[,] employeeData = new double[10, 2];
        double[,] resultData = new double[10, 2];

        double totalOldSalary = 0;
        double totalBonus = 0;
        double totalNewSalary = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Enter details for employee {i + 1}:");
            Console.Write("Salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Years of service: ");
            double years = Convert.ToDouble(Console.ReadLine());

            if (salary <= 0 || years < 0)
            {
                Console.WriteLine("Invalid input. Please enter positive numbers.");
                i--;
                continue;
            }

            employeeData[i, 0] = salary;
            employeeData[i, 1] = years;
        }

        for (int i = 0; i < 10; i++)
        {
            double salary = employeeData[i, 0];
            double years = employeeData[i, 1];

            double bonusRate = years > 5 ? 0.05 : 0.02;
            double bonus = salary * bonusRate;
            double newSalary = salary + bonus;

            resultData[i, 0] = bonus;
            resultData[i, 1] = newSalary;

            totalOldSalary += salary;
            totalBonus += bonus;
            totalNewSalary += newSalary;
        }

        Console.WriteLine($"Total Old Salary: {totalOldSalary}");
        Console.WriteLine($"Total Bonus Payout: {totalBonus}");
        Console.WriteLine($"Total New Salary: {totalNewSalary}");
    }
}
