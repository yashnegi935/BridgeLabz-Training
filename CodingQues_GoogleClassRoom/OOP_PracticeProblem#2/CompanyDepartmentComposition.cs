namespace CalculatorProblems;

public class CompEmployee
{
    public int Id { get; set; }
    public string Name { get; set; }

    public CompEmployee(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public void Display()
    {
        Console.WriteLine($"Employee [{Id}]: {Name}");
    }
}

public class CompDepartment
{
    public string DepartmentName { get; set; }
    public List<CompEmployee> Employees { get; set; }

    public CompDepartment(string departmentName)
    {
        DepartmentName = departmentName;
        Employees = new List<CompEmployee>();
    }

    public void AddEmployee(int id, string name)
    {
        Employees.Add(new CompEmployee(id, name));
    }

    public void Display()
    {
        Console.WriteLine($"Department: {DepartmentName}");
        foreach (var emp in Employees)
        {
            emp.Display();
        }
    }
}

public class CompCompany
{
    public string CompanyName { get; set; }
    public List<CompDepartment> Departments { get; set; }

    public CompCompany(string companyName)
    {
        CompanyName = companyName;
        Departments = new List<CompDepartment>();
    }

    public CompDepartment CreateDepartment(string deptName)
    {
        CompDepartment dept = new CompDepartment(deptName);
        Departments.Add(dept);
        return dept;
    }

    public void CloseCompany()
    {
        Departments.Clear();
        Console.WriteLine($"Company '{CompanyName}' and all its departments & employees have been dissolved.");
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"=== Company: {CompanyName} ===");
        if (Departments.Count == 0)
        {
            Console.WriteLine("No active departments.");
            return;
        }

        foreach (var dept in Departments)
        {
            dept.Display();
        }
    }
}

public class CompanyDepartmentComposition
{
    public static void Run()
    {
        CompCompany techCorp = new CompCompany("TechCorp Solutions");

        CompDepartment dev = techCorp.CreateDepartment("Engineering");
        dev.AddEmployee(101, "David");
        dev.AddEmployee(102, "Eva");

        CompDepartment hr = techCorp.CreateDepartment("Human Resources");
        hr.AddEmployee(201, "Frank");

        techCorp.DisplayDetails();

        Console.WriteLine("\nDissolving Company...");
        techCorp.CloseCompany();

        Console.WriteLine();
        techCorp.DisplayDetails();
    }
}
