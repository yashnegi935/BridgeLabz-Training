namespace CalculatorProblems;

public class Problem2
{
    public static void Run()
    {
        Console.Write("Enter a date (yyyy-MM-dd): ");
        string? input = Console.ReadLine();

        if (DateTime.TryParse(input, out DateTime date))
        {
            DateTime addedDate = date.AddDays(7).AddMonths(1).AddYears(2);
            DateTime finalDate = addedDate.AddDays(-21);

            Console.WriteLine($"Original Date: {date:yyyy-MM-dd}");
            Console.WriteLine($"After Adding 7 Days, 1 Month, and 2 Years: {addedDate:yyyy-MM-dd}");
            Console.WriteLine($"After Subtracting 3 Weeks: {finalDate:yyyy-MM-dd}");
        }
        else
        {
            Console.WriteLine("Invalid date format. Please try again.");
        }
    }
}
