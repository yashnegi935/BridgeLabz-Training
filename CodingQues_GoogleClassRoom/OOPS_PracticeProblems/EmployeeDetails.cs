namespace CalculatorProblems;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }

    public Employee(int id, string name, double salary)
    {
        Id = id;
        Name = name;
        Salary = salary;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("\n--- Employee Details ---");
        Console.WriteLine($"Employee ID : {Id}");
        Console.WriteLine($"Name        : {Name}");
        Console.WriteLine($"Salary      : {Salary}");
    }
}

public class EmployeeDetails
{
    public static void Run()
    {
        Console.Write("Enter Employee ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine() ?? "";

        Console.Write("Enter Employee Salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Employee employee = new Employee(id, name, salary);
        employee.DisplayDetails();
    }
}
