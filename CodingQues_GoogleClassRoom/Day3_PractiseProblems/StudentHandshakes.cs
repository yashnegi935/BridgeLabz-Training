namespace CalculatorProblems;

public class StudentHandshakes
{
    public static void Run()
    {
        Console.Write("Enter number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        int handshakes = CalculateHandshakes(numberOfStudents);

        Console.WriteLine($"The maximum number of possible handshakes among {numberOfStudents} students is {handshakes}");
    }

    public static int CalculateHandshakes(int numberOfStudents)
    {
        return (numberOfStudents * (numberOfStudents - 1)) / 2;
    }
}
