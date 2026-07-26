namespace CalculatorProblems;

public class FindFactorsDynamicArray
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int maxFactor = 10;
        int[] factors = new int[maxFactor];
        int index = 0;

        for (int i = 1; i <= Math.Abs(number); i++)
        {
            if (number % i == 0)
            {
                if (index == maxFactor)
                {
                    maxFactor *= 2;
                    int[] temp = new int[maxFactor];
                    for (int k = 0; k < factors.Length; k++)
                    {
                        temp[k] = factors[k];
                    }
                    factors = temp;
                }

                factors[index] = i;
                index++;
            }
        }

        Console.Write($"Factors of {number}: ");
        for (int i = 0; i < index; i++)
        {
            Console.Write(factors[i] + " ");
        }
        Console.WriteLine();
    }
}
