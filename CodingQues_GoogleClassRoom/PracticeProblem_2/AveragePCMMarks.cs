namespace CalculatorProblems;

public class AveragePCMMarks
{
    public static void Run()
    {
        int maths = 94;
        int physics = 95;
        int chemistry = 96;

        double average = (maths + physics + chemistry) / 3.0;

        Console.WriteLine("Sam's average mark in PCM is " + average);
    }
}