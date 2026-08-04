namespace CalculatorProblems;

public interface IDepartment
{
    void AssignDepartment(string deptName);
    string GetDepartmentDetails();
}

public abstract class AbsEmployee
{
    private int employeeId;
    private string name;
    private double baseSalary;

    public int EmployeeId
    {
        get { return employeeId; }
        set { employeeId = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double BaseSalary
    {
        get { return baseSalary; }
        set { baseSalary = value; }
    }

    public AbsEmployee(int employeeId, string name, double baseSalary)
    {
        this.employeeId = employeeId;
        this.name = name;
        this.baseSalary = baseSalary;
    }

    public abstract double CalculateSalary();

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"ID: {EmployeeId}, Name: {Name}, Calculated Salary: {CalculateSalary():C}");
    }
}

public class FullTimeEmployee : AbsEmployee, IDepartment
{
    private string departmentName = "Unassigned";
    public double Bonus { get; set; }

    public FullTimeEmployee(int employeeId, string name, double baseSalary, double bonus)
        : base(employeeId, name, baseSalary)
    {
        Bonus = bonus;
    }

    public override double CalculateSalary()
    {
        return BaseSalary + Bonus;
    }

    public void AssignDepartment(string deptName)
    {
        departmentName = deptName;
    }

    public string GetDepartmentDetails()
    {
        return departmentName;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"[Full-Time] ID: {EmployeeId}, Name: {Name}, Dept: {GetDepartmentDetails()}, Salary: {CalculateSalary():C}");
    }
}

public class PartTimeEmployee : AbsEmployee, IDepartment
{
    private string departmentName = "Unassigned";
    public int HoursWorked { get; set; }
    public double HourlyRate { get; set; }

    public PartTimeEmployee(int employeeId, string name, int hoursWorked, double hourlyRate)
        : base(employeeId, name, 0)
    {
        HoursWorked = hoursWorked;
        HourlyRate = hourlyRate;
    }

    public override double CalculateSalary()
    {
        return HoursWorked * HourlyRate;
    }

    public void AssignDepartment(string deptName)
    {
        departmentName = deptName;
    }

    public string GetDepartmentDetails()
    {
        return departmentName;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"[Part-Time] ID: {EmployeeId}, Name: {Name}, Dept: {GetDepartmentDetails()}, Salary: {CalculateSalary():C}");
    }
}

public class EmployeeManagementSystem
{
    public static void Run()
    {
        Console.WriteLine("--- Employee Management System ---");

        FullTimeEmployee ft = new FullTimeEmployee(101, "Alice Johnson", 60000, 5000);
        ft.AssignDepartment("Engineering");

        PartTimeEmployee pt = new PartTimeEmployee(102, "Bob Smith", 80, 25.0);
        pt.AssignDepartment("Support");

        List<AbsEmployee> employees = new List<AbsEmployee> { ft, pt };

        foreach (var emp in employees)
        {
            emp.DisplayDetails();
        }
    }
}
