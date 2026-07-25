namespace CalculatorProblems;

public class CountDigits
{
    public static void Run()
    {
        Console.Write("Enter an integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int count = 0;
        int temp = number;

        if (temp == 0)
        {
            count = 1;
        }
        else
        {
            while (temp != 0)
            {
                temp /= 10;
                count++;
            }
        }

        Console.WriteLine($"Number of digits in {number} = {count}");
    }
}
