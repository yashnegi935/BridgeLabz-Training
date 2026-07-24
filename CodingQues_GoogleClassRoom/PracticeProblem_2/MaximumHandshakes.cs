namespace CalculatorProblems;

public class MaximumHandshakes
{
    public static void Run()
    {
        Console.Write("Enter Number of Students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

        Console.WriteLine("Maximum possible handshakes are " + handshakes);
    }
}