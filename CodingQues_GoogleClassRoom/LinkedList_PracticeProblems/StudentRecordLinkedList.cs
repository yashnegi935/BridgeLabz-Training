namespace CalculatorProblems;

public class StudentRecordNode
{
    public int RollNumber { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }
    public StudentRecordNode? Next { get; set; }

    public StudentRecordNode(int rollNumber, string name, int age, string grade)
    {
        RollNumber = rollNumber;
        Name = name;
        Age = age;
        Grade = grade;
        Next = null;
    }
}

public class StudentRecordList
{
    private StudentRecordNode? head;

    public void AddAtBeginning(int roll, string name, int age, string grade)
    {
        StudentRecordNode newNode = new StudentRecordNode(roll, name, age, grade);
        newNode.Next = head;
        head = newNode;
    }

    public void AddAtEnd(int roll, string name, int age, string grade)
    {
        StudentRecordNode newNode = new StudentRecordNode(roll, name, age, grade);
        if (head == null)
        {
            head = newNode;
            return;
        }
        StudentRecordNode temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = newNode;
    }

    public void AddAtPosition(int position, int roll, string name, int age, string grade)
    {
        if (position <= 1 || head == null)
        {
            AddAtBeginning(roll, name, age, grade);
            return;
        }
        StudentRecordNode newNode = new StudentRecordNode(roll, name, age, grade);
        StudentRecordNode temp = head;
        for (int i = 1; i < position - 1 && temp.Next != null; i++)
        {
            temp = temp.Next;
        }
        newNode.Next = temp.Next;
        temp.Next = newNode;
    }

    public bool DeleteByRollNumber(int roll)
    {
        if (head == null) return false;
        if (head.RollNumber == roll)
        {
            head = head.Next;
            return true;
        }
        StudentRecordNode temp = head;
        while (temp.Next != null && temp.Next.RollNumber != roll)
        {
            temp = temp.Next;
        }
        if (temp.Next == null) return false;
        temp.Next = temp.Next.Next;
        return true;
    }

    public StudentRecordNode? SearchByRollNumber(int roll)
    {
        StudentRecordNode? temp = head;
        while (temp != null)
        {
            if (temp.RollNumber == roll) return temp;
            temp = temp.Next;
        }
        return null;
    }

    public bool UpdateGrade(int roll, string newGrade)
    {
        StudentRecordNode? student = SearchByRollNumber(roll);
        if (student != null)
        {
            student.Grade = newGrade;
            return true;
        }
        return false;
    }

    public void DisplayAll()
    {
        if (head == null)
        {
            Console.WriteLine("No student records found.");
            return;
        }
        StudentRecordNode? temp = head;
        while (temp != null)
        {
            Console.WriteLine($"Roll No: {temp.RollNumber}, Name: {temp.Name}, Age: {temp.Age}, Grade: {temp.Grade}");
            temp = temp.Next;
        }
    }
}

public class StudentRecordLinkedList
{
    public static void Run()
    {
        Console.WriteLine("--- Singly Linked List: Student Record Management ---");

        StudentRecordList list = new StudentRecordList();
        list.AddAtBeginning(101, "Alice", 20, "A");
        list.AddAtEnd(102, "Bob", 21, "B");
        list.AddAtEnd(103, "Charlie", 22, "B+");
        list.AddAtPosition(2, 104, "David", 19, "A+");

        Console.WriteLine("Initial Student Records:");
        list.DisplayAll();

        Console.WriteLine("\nUpdating Grade for Roll No 102 to 'A'...");
        list.UpdateGrade(102, "A");

        Console.WriteLine("\nSearching for Roll No 104...");
        var searched = list.SearchByRollNumber(104);
        if (searched != null)
        {
            Console.WriteLine($"Found: {searched.Name}, Grade: {searched.Grade}");
        }

        Console.WriteLine("\nDeleting Roll No 101...");
        list.DeleteByRollNumber(101);

        Console.WriteLine("\nUpdated Student Records:");
        list.DisplayAll();
    }
}
