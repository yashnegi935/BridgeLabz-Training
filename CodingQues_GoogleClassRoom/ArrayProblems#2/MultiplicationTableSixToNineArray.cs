namespace CalculatorProblems;

public class MultiplicationTableSixToNineArray
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] multiplicationResult = new int[4];

        for (int i = 6; i <= 9; i++)
        {
            multiplicationResult[i - 6] = number * i;
        }

        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine($"{number} * {i} = {multiplicationResult[i - 6]}");
        }
    }
}
