namespace CalculatorProblems;

public class PenDistribution
{
    public static void Run()
    {
        int pens = 14;
        int students = 3;

        int penPerStudent = pens / students;
        int remainingPens = pens % students;

        Console.WriteLine("The Pen Per Student is " + penPerStudent + " and the remaining pen not distributed is " + remainingPens);
    }
}