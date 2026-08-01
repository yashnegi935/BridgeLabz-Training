namespace CalculatorProblems;

public class SchoolSubject
{
    public string Name { get; set; }
    public double Marks { get; set; }

    public SchoolSubject(string name, double marks)
    {
        Name = name;
        Marks = marks;
    }
}

public class StudentResult
{
    public string Name { get; set; }
    public List<SchoolSubject> Subjects { get; set; }

    public StudentResult(string name)
    {
        Name = name;
        Subjects = new List<SchoolSubject>();
    }

    public void AddSubject(SchoolSubject subject)
    {
        Subjects.Add(subject);
    }
}

public class GradeCalculator
{
    public double CalculateAverage(StudentResult student)
    {
        if (student.Subjects.Count == 0) return 0;
        double total = 0;
        foreach (var sub in student.Subjects)
        {
            total += sub.Marks;
        }
        return total / student.Subjects.Count;
    }

    public string CalculateGrade(double average)
    {
        if (average >= 90) return "A+";
        if (average >= 80) return "A";
        if (average >= 70) return "B";
        if (average >= 60) return "C";
        return "F";
    }

    public void DisplayReport(StudentResult student)
    {
        Console.WriteLine($"--- Student Result Report: {student.Name} ---");
        foreach (var sub in student.Subjects)
        {
            Console.WriteLine($"Subject: {sub.Name}, Marks: {sub.Marks}");
        }
        double avg = CalculateAverage(student);
        string grade = CalculateGrade(avg);
        Console.WriteLine($"Average Marks: {avg:F2}");
        Console.WriteLine($"Final Grade  : {grade}");
    }
}

public class SchoolResultsApplication
{
    public static void Run()
    {
        StudentResult student = new StudentResult("John");

        SchoolSubject maths = new SchoolSubject("Maths", 90);
        SchoolSubject science = new SchoolSubject("Science", 85);

        student.AddSubject(maths);
        student.AddSubject(science);

        GradeCalculator calculator = new GradeCalculator();
        calculator.DisplayReport(student);
    }
}
