namespace CalculatorProblems;

public class StudentGradeCalculator
{
    public static void Run()
    {
        Console.Write("Enter number of students: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] physics = new int[number];
        int[] chemistry = new int[number];
        int[] maths = new int[number];
        double[] percentage = new double[number];
        string[] grade = new string[number];

        for (int i = 0; i < number; i++)
        {
            Console.WriteLine($"\nEnter marks for Student {i + 1} (out of 100):");
            Console.Write("Physics: ");
            int p = Convert.ToInt32(Console.ReadLine());

            Console.Write("Chemistry: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.Write("Maths: ");
            int m = Convert.ToInt32(Console.ReadLine());

            if (p < 0 || c < 0 || m < 0)
            {
                Console.WriteLine("Marks cannot be negative. Please enter positive values.");
                i--;
                continue;
            }

            physics[i] = p;
            chemistry[i] = c;
            maths[i] = m;

            double pct = (p + c + m) / 3.0;
            percentage[i] = pct;

            if (pct >= 80)
            {
                grade[i] = "A";
            }
            else if (pct >= 70)
            {
                grade[i] = "B";
            }
            else if (pct >= 60)
            {
                grade[i] = "C";
            }
            else if (pct >= 50)
            {
                grade[i] = "D";
            }
            else if (pct >= 40)
            {
                grade[i] = "E";
            }
            else
            {
                grade[i] = "F";
            }
        }

        Console.WriteLine("\n--- Student Results ---");
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine($"Student {i + 1}: Physics = {physics[i]}, Chemistry = {chemistry[i]}, Maths = {maths[i]}, Percentage = {percentage[i]:F2}%, Grade = {grade[i]}");
        }
    }
}
