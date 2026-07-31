namespace CalculatorProblems;

public class Student
{
    public int RollNumber;
    protected string Name;
    private double cgpa;

    public Student(int rollNumber, string name, double cgpa)
    {
        RollNumber = rollNumber;
        Name = name;
        this.cgpa = cgpa;
    }

    public double GetCGPA()
    {
        return cgpa;
    }

    public void SetCGPA(double newCGPA)
    {
        if (newCGPA >= 0.0 && newCGPA <= 10.0)
        {
            cgpa = newCGPA;
        }
    }

    public void DisplayStudentInfo()
    {
        Console.WriteLine($"Roll No: {RollNumber}, Name: {Name}, CGPA: {cgpa}");
    }
}

public class PostgraduateStudent : Student
{
    public string Specialization { get; set; }

    public PostgraduateStudent(int rollNumber, string name, double cgpa, string specialization)
        : base(rollNumber, name, cgpa)
    {
        Specialization = specialization;
    }

    public void DisplayPostgraduateDetails()
    {
        Console.WriteLine($"PG Student Roll No: {RollNumber}, Name (Protected): {Name}, Specialization: {Specialization}, CGPA (Public Accessor): {GetCGPA()}");
    }
}

public class UniversityManagement
{
    public static void Run()
    {
        Console.WriteLine("--- University Management System ---");

        Student student = new Student(101, "John Doe", 8.5);
        student.DisplayStudentInfo();

        Console.WriteLine("Updating CGPA via public setter...");
        student.SetCGPA(9.1);
        Console.WriteLine($"Updated CGPA: {student.GetCGPA()}");

        Console.WriteLine("\nPostgraduate Student Details:");
        PostgraduateStudent pgStudent = new PostgraduateStudent(201, "Jane Smith", 9.4, "Computer Science");
        pgStudent.DisplayPostgraduateDetails();
    }
}
