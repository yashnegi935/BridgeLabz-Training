namespace CalculatorProblems;

public class Problem4
{
    public static void Run()
    {
        Console.Write("Enter first date (yyyy-MM-dd): ");
        string? input1 = Console.ReadLine();

        Console.Write("Enter second date (yyyy-MM-dd): ");
        string? input2 = Console.ReadLine();

        if (DateTime.TryParse(input1, out DateTime date1) && DateTime.TryParse(input2, out DateTime date2))
        {
            int comparison = DateTime.Compare(date1, date2);

            if (comparison < 0)
            {
                Console.WriteLine($"{date1:yyyy-MM-dd} is BEFORE {date2:yyyy-MM-dd}");
            }
            else if (comparison > 0)
            {
                Console.WriteLine($"{date1:yyyy-MM-dd} is AFTER {date2:yyyy-MM-dd}");
            }
            else
            {
                Console.WriteLine($"{date1:yyyy-MM-dd} is the SAME AS {date2:yyyy-MM-dd}");
            }
        }
        else
        {
            Console.WriteLine("Invalid date input. Please enter valid dates.");
        }
    }
}
