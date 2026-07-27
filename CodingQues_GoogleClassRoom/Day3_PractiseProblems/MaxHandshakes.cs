namespace CalculatorProblems;

public class MaxHandshakes
{
    public static void Run()
    {
        Console.Write("Enter numberOfStudents: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        int possibleHandshakes = CalculateHandshakes(numberOfStudents);

        Console.WriteLine($"Number of possible handshakes: {possibleHandshakes}");
    }

    public static int CalculateHandshakes(int numberOfStudents)
    {
        return (numberOfStudents * (numberOfStudents - 1)) / 2;
    }
}
