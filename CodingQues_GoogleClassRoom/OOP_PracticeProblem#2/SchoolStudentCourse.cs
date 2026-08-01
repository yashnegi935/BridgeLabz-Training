namespace CalculatorProblems;

public class SchoolCourse
{
    public string CourseCode { get; set; }
    public string CourseName { get; set; }
    public List<SchoolStudent> EnrolledStudents { get; set; }

    public SchoolCourse(string courseCode, string courseName)
    {
        CourseCode = courseCode;
        CourseName = courseName;
        EnrolledStudents = new List<SchoolStudent>();
    }

    public void DisplayEnrolledStudents()
    {
        Console.WriteLine($"Students enrolled in {CourseName} ({CourseCode}):");
        foreach (var student in EnrolledStudents)
        {
            Console.WriteLine($"- {student.Name}");
        }
    }
}

public class SchoolStudent
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public List<SchoolCourse> EnrolledCourses { get; set; }

    public SchoolStudent(int studentId, string name)
    {
        StudentId = studentId;
        Name = name;
        EnrolledCourses = new List<SchoolCourse>();
    }

    public void EnrollInCourse(SchoolCourse course)
    {
        if (!EnrolledCourses.Contains(course))
        {
            EnrolledCourses.Add(course);
            course.EnrolledStudents.Add(this);
        }
    }

    public void DisplayEnrolledCourses()
    {
        Console.WriteLine($"Courses enrolled by {Name}:");
        foreach (var course in EnrolledCourses)
        {
            Console.WriteLine($"- {course.CourseName} ({course.CourseCode})");
        }
    }
}

public class School
{
    public string SchoolName { get; set; }
    public List<SchoolStudent> Students { get; set; }

    public School(string schoolName)
    {
        SchoolName = schoolName;
        Students = new List<SchoolStudent>();
    }

    public void AddStudent(SchoolStudent student)
    {
        Students.Add(student);
    }
}

public class SchoolStudentCourse
{
    public static void Run()
    {
        School school = new School("Greenwood High");

        SchoolStudent s1 = new SchoolStudent(1, "John");
        SchoolStudent s2 = new SchoolStudent(2, "Emma");

        school.AddStudent(s1);
        school.AddStudent(s2);

        SchoolCourse math = new SchoolCourse("MATH101", "Mathematics");
        SchoolCourse science = new SchoolCourse("SCI102", "Physics");

        s1.EnrollInCourse(math);
        s1.EnrollInCourse(science);
        s2.EnrollInCourse(math);

        s1.DisplayEnrolledCourses();
        Console.WriteLine();
        s2.DisplayEnrolledCourses();
        Console.WriteLine();
        math.DisplayEnrolledStudents();
    }
}
