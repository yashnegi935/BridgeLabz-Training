namespace CalculatorProblems;

public class MultiCourse
{
    public string CourseName { get; set; }
    public string Duration { get; set; }

    public MultiCourse(string courseName, string duration)
    {
        CourseName = courseName;
        Duration = duration;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Course: {CourseName}, Duration: {Duration}");
    }
}

public class MultiOnlineCourse : MultiCourse
{
    public string Platform { get; set; }
    public bool IsRecorded { get; set; }

    public MultiOnlineCourse(string courseName, string duration, string platform, bool isRecorded)
        : base(courseName, duration)
    {
        Platform = platform;
        IsRecorded = isRecorded;
    }

    public override void DisplayInfo()
    {
        string recordedStr = IsRecorded ? "Yes" : "No";
        Console.WriteLine($"Online Course: {CourseName}, Duration: {Duration}, Platform: {Platform}, Recorded: {recordedStr}");
    }
}

public class MultiPaidOnlineCourse : MultiOnlineCourse
{
    public double Fee { get; set; }
    public double Discount { get; set; }

    public MultiPaidOnlineCourse(string courseName, string duration, string platform, bool isRecorded, double fee, double discount)
        : base(courseName, duration, platform, isRecorded)
    {
        Fee = fee;
        Discount = discount;
    }

    public double GetFinalFee()
    {
        return Fee - Discount;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Fee: {Fee:C}, Discount: {Discount:C}, Final Price: {GetFinalFee():C}");
    }
}

public class CourseMultilevelInheritance
{
    public static void Run()
    {
        Console.WriteLine("--- Multilevel Inheritance: Educational Course ---");

        MultiPaidOnlineCourse course = new MultiPaidOnlineCourse("C# Masterclass", "30 Hours", "Udemy", true, 199.99, 50.00);
        course.DisplayInfo();
    }
}
