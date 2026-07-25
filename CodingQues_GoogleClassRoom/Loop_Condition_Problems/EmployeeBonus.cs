namespace CalculatorProblems;

public class EmployeeBonus
{
    public static void Run()
    {
        Console.Write("Enter Salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Years of Service: ");
        double yearsOfService = Convert.ToDouble(Console.ReadLine());

        if (yearsOfService > 5)
        {
            double bonus = salary * 0.05;
            Console.WriteLine($"Bonus amount: {bonus}");
        }
        else
        {
            Console.WriteLine("No bonus awarded.");
        }
    }
}
