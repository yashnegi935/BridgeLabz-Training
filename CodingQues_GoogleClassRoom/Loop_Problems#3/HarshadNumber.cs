namespace CalculatorProblems;

public class HarshadNumber
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        int temp = number;

        while (temp != 0)
        {
            int digit = temp % 10;
            sum += digit;
            temp /= 10;
        }

        if (sum != 0 && number % sum == 0)
        {
            Console.WriteLine("Harshad Number");
        }
        else
        {
            Console.WriteLine("Not a Harshad Number");
        }
    }
}
