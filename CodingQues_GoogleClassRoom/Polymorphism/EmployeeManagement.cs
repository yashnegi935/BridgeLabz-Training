namespace CalculatorProblems;

public class EmpEmployee
{
    public string Name { get; set; }
    public int Id { get; set; }
    public double Salary { get; set; }

    public EmpEmployee(string name, int id, double salary)
    {
        Name = name;
        Id = id;
        Salary = salary;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Salary: {Salary:C}");
    }
}

public class EmpManager : EmpEmployee
{
    public int TeamSize { get; set; }

    public EmpManager(string name, int id, double salary, int teamSize) : base(name, id, salary)
    {
        TeamSize = teamSize;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"[Manager] ID: {Id}, Name: {Name}, Salary: {Salary:C}, Team Size: {TeamSize}");
    }
}

public class EmpDeveloper : EmpEmployee
{
    public string ProgrammingLanguage { get; set; }

    public EmpDeveloper(string name, int id, double salary, string language) : base(name, id, salary)
    {
        ProgrammingLanguage = language;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"[Developer] ID: {Id}, Name: {Name}, Salary: {Salary:C}, Language: {ProgrammingLanguage}");
    }
}

public class EmpIntern : EmpEmployee
{
    public string InternshipDuration { get; set; }

    public EmpIntern(string name, int id, double salary, string duration) : base(name, id, salary)
    {
        InternshipDuration = duration;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"[Intern] ID: {Id}, Name: {Name}, Salary: {Salary:C}, Duration: {InternshipDuration}");
    }
}

public class EmployeeManagement
{
    public static void Run()
    {
        Console.WriteLine("--- Employee Management System ---");

        List<EmpEmployee> employees = new List<EmpEmployee>
        {
            new EmpManager("Alice", 101, 95000, 10),
            new EmpDeveloper("Bob", 102, 75000, "C#"),
            new EmpIntern("Charlie", 103, 25000, "6 Months")
        };

        foreach (var emp in employees)
        {
            emp.DisplayDetails();
        }
    }
}
