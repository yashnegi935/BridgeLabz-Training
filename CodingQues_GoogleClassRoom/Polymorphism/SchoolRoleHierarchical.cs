namespace CalculatorProblems;

public class HierPerson
{
    public string Name { get; set; }
    public int Age { get; set; }

    public HierPerson(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void DisplayRole()
    {
        Console.WriteLine($"Person: {Name}, Age: {Age}");
    }
}

public class HierTeacher : HierPerson
{
    public string Subject { get; set; }

    public HierTeacher(string name, int age, string subject) : base(name, age)
    {
        Subject = subject;
    }

    public override void DisplayRole()
    {
        Console.WriteLine($"Teacher: {Name}, Age: {Age}, Teaches: {Subject}");
    }
}

public class HierStudent : HierPerson
{
    public string Grade { get; set; }

    public HierStudent(string name, int age, string grade) : base(name, age)
    {
        Grade = grade;
    }

    public override void DisplayRole()
    {
        Console.WriteLine($"Student: {Name}, Age: {Age}, Grade Level: {Grade}");
    }
}

public class HierStaff : HierPerson
{
    public string Department { get; set; }

    public HierStaff(string name, int age, string department) : base(name, age)
    {
        Department = department;
    }

    public override void DisplayRole()
    {
        Console.WriteLine($"Staff: {Name}, Age: {Age}, Department: {Department}");
    }
}

public class SchoolRoleHierarchical
{
    public static void Run()
    {
        Console.WriteLine("--- Hierarchical Inheritance: School Roles ---");

        List<HierPerson> people = new List<HierPerson>
        {
            new HierTeacher("Mrs. Davis", 40, "Mathematics"),
            new HierStudent("Lucas", 15, "10th Grade"),
            new HierStaff("Mr. Miller", 50, "Administration")
        };

        foreach (var person in people)
        {
            person.DisplayRole();
        }
    }
}
