namespace CalculatorProblems;

public class Course
{
    public string CourseName { get; set; }
    public string Duration { get; set; }
    public double Fee { get; set; }
    public static string InstituteName { get; private set; } = "Tech Academy";

    public Course(string courseName, string duration, double fee)
    {
        CourseName = courseName;
        Duration = duration;
        Fee = fee;
    }

    public void DisplayCourseDetails()
    {
        Console.WriteLine($"Institute: {InstituteName}, Course: {CourseName}, Duration: {Duration}, Fee: {Fee}");
    }

    public static void UpdateInstituteName(string newName)
    {
        InstituteName = newName;
    }
}

public class CourseManagement
{
    public static void Run()
    {
        Console.WriteLine("--- Online Course Management ---");

        Course c1 = new Course("C# Programming", "3 Months", 500);
        Course c2 = new Course("Web Development", "6 Months", 800);

        Console.WriteLine("Before Institute Name Update:");
        c1.DisplayCourseDetails();
        c2.DisplayCourseDetails();

        Console.WriteLine("\nUpdating Institute Name...");
        Course.UpdateInstituteName("Global Tech Institute");

        Console.WriteLine("\nAfter Institute Name Update:");
        c1.DisplayCourseDetails();
        c2.DisplayCourseDetails();
    }
}
