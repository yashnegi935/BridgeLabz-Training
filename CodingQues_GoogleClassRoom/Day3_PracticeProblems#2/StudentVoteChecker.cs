namespace CalculatorProblems;

public class StudentVoteChecker
{
    public static void Run()
    {
        int[] ages = new int[10];

        for (int i = 0; i < ages.Length; i++)
        {
            Console.Write($"Enter age for student {i + 1}: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());

            if (CanStudentVote(ages[i]))
            {
                Console.WriteLine($"Student {i + 1} (Age: {ages[i]}) CAN vote.");
            }
            else
            {
                Console.WriteLine($"Student {i + 1} (Age: {ages[i]}) CANNOT vote.");
            }
        }
    }

    public static bool CanStudentVote(int age)
    {
        if (age < 0)
        {
            return false;
        }

        return age >= 18;
    }
}
