namespace CalculatorProblems;

public class FindSmallestLargest
{
    public static void Run()
    {
        Console.Write("Enter number 1: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number 2: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number 3: ");
        int number3 = Convert.ToInt32(Console.ReadLine());

        int[] result = FindSmallestAndLargest(number1, number2, number3);

        Console.WriteLine($"Smallest number: {result[0]}");
        Console.WriteLine($"Largest number: {result[1]}");
    }

    public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
    {
        int smallest = Math.Min(number1, Math.Min(number2, number3));
        int largest = Math.Max(number1, Math.Max(number2, number3));

        return new int[] { smallest, largest };
    }
}
