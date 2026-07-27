namespace CalculatorProblems;

public class StudentScorecard
{
    public static void Run()
    {
        Console.Write("Enter number of students: ");
        int count = Convert.ToInt32(Console.ReadLine());

        double[,] pcmScores = GenerateScores(count);
        double[,] results = CalculateResults(pcmScores);
        DisplayScorecard(pcmScores, results);
    }

    public static double[,] GenerateScores(int numStudents)
    {
        Random random = new Random();
        double[,] scores = new double[numStudents, 3];
        for (int i = 0; i < numStudents; i++)
        {
            scores[i, 0] = random.Next(10, 100);
            scores[i, 1] = random.Next(10, 100);
            scores[i, 2] = random.Next(10, 100);
        }
        return scores;
    }

    public static double[,] CalculateResults(double[,] scores)
    {
        int numStudents = scores.GetLength(0);
        double[,] results = new double[numStudents, 3];
        for (int i = 0; i < numStudents; i++)
        {
            double physics = scores[i, 0];
            double chemistry = scores[i, 1];
            double maths = scores[i, 2];

            double total = physics + chemistry + maths;
            double average = total / 3.0;
            double percentage = (total / 300.0) * 100.0;

            results[i, 0] = Math.Round(total, 2);
            results[i, 1] = Math.Round(average, 2);
            results[i, 2] = Math.Round(percentage, 2);
        }
        return results;
    }

    public static void DisplayScorecard(double[,] scores, double[,] results)
    {
        int numStudents = scores.GetLength(0);
        Console.WriteLine("Std#\tPhysics\tChem\tMaths\tTotal\tAvg\tPercentage");
        Console.WriteLine("------------------------------------------------------------------");
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine($"{i + 1}\t{scores[i, 0]}\t{scores[i, 1]}\t{scores[i, 2]}\t{results[i, 0]}\t{results[i, 1]}\t{results[i, 2]}%");
        }
    }
}
