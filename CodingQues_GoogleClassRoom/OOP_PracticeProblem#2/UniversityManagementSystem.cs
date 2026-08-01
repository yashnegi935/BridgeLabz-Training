namespace CalculatorProblems;

public class UniSysCourse
{
    public string Code { get; set; }
    public string Title { get; set; }
    public UniSysProfessor? AssignedProfessor { get; set; }
    public List<UniSysStudent> EnrolledStudents { get; set; }

    public UniSysCourse(string code, string title)
    {
        Code = code;
        Title = title;
        EnrolledStudents = new List<UniSysStudent>();
    }

    public void DisplayCourseInfo()
    {
        string profName = AssignedProfessor != null ? AssignedProfessor.Name : "Unassigned";
        Console.WriteLine($"Course: {Title} ({Code}) | Professor: {profName} | Enrolled Students: {EnrolledStudents.Count}");
    }
}

public class UniSysStudent
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public List<UniSysCourse> Courses { get; set; }

    public UniSysStudent(int studentId, string name)
    {
        StudentId = studentId;
        Name = name;
        Courses = new List<UniSysCourse>();
    }

    public void EnrollCourse(UniSysCourse course)
    {
        if (!Courses.Contains(course))
        {
            Courses.Add(course);
            course.EnrolledStudents.Add(this);
            Console.WriteLine($"Student {Name} enrolled in {course.Title}.");
        }
    }
}

public class UniSysProfessor
{
    public int ProfId { get; set; }
    public string Name { get; set; }
    public List<UniSysCourse> TaughtCourses { get; set; }

    public UniSysProfessor(int profId, string name)
    {
        ProfId = profId;
        Name = name;
        TaughtCourses = new List<UniSysCourse>();
    }

    public void AssignProfessor(UniSysCourse course)
    {
        if (!TaughtCourses.Contains(course))
        {
            TaughtCourses.Add(course);
            course.AssignedProfessor = this;
            Console.WriteLine($"Professor {Name} assigned to teach {course.Title}.");
        }
    }
}

public class UniversityManagementSystem
{
    public static void Run()
    {
        UniSysCourse c1 = new UniSysCourse("CS101", "Data Structures");
        UniSysCourse c2 = new UniSysCourse("CS102", "Algorithms");

        UniSysStudent s1 = new UniSysStudent(1, "Alice");
        UniSysStudent s2 = new UniSysStudent(2, "Bob");

        UniSysProfessor prof = new UniSysProfessor(101, "Dr. Turing");

        prof.AssignProfessor(c1);
        prof.AssignProfessor(c2);

        s1.EnrollCourse(c1);
        s2.EnrollCourse(c1);
        s2.EnrollCourse(c2);

        Console.WriteLine();
        c1.DisplayCourseInfo();
        c2.DisplayCourseInfo();
    }
}
