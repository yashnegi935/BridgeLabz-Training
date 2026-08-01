namespace CalculatorProblems;

public class FacultyMember
{
    public int FacultyId { get; set; }
    public string Name { get; set; }
    public string Designation { get; set; }

    public FacultyMember(int facultyId, string name, string designation)
    {
        FacultyId = facultyId;
        Name = name;
        Designation = designation;
    }

    public void Display()
    {
        Console.WriteLine($"Faculty [{FacultyId}]: {Name}, {Designation}");
    }
}

public class UniDept
{
    public string Name { get; set; }

    public UniDept(string name)
    {
        Name = name;
    }
}

public class UniVarsity
{
    public string Name { get; set; }
    public List<UniDept> Departments { get; set; }
    public List<FacultyMember> FacultyMembers { get; set; }

    public UniVarsity(string name)
    {
        Name = name;
        Departments = new List<UniDept>();
        FacultyMembers = new List<FacultyMember>();
    }

    public void AddDepartment(string deptName)
    {
        Departments.Add(new UniDept(deptName));
    }

    public void AttachFaculty(FacultyMember faculty)
    {
        FacultyMembers.Add(faculty);
    }

    public void CloseUniversity()
    {
        Departments.Clear();
        Console.WriteLine($"University '{Name}' closed. All departments destroyed.");
    }
}

public class UniversityFacultyDepartment
{
    public static void Run()
    {
        FacultyMember prof1 = new FacultyMember(1, "Dr. Smith", "Professor");
        FacultyMember prof2 = new FacultyMember(2, "Dr. Adams", "Associate Professor");

        UniVarsity uni = new UniVarsity("State University");
        uni.AddDepartment("Computer Science");
        uni.AddDepartment("Electrical Engineering");

        uni.AttachFaculty(prof1);
        uni.AttachFaculty(prof2);

        Console.WriteLine($"University: {uni.Name} has {uni.Departments.Count} departments.");
        Console.WriteLine("\nFaculty Members:");
        prof1.Display();
        prof2.Display();

        Console.WriteLine("\nClosing University...");
        uni.CloseUniversity();

        Console.WriteLine("\nFaculty Members after University Closure (Aggregation Demonstration):");
        prof1.Display();
        prof2.Display();
    }
}
