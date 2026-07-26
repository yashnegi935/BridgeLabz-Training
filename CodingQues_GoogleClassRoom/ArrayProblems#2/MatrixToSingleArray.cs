namespace CalculatorProblems;

public class MatrixToSingleArray
{
    public static void Run()
    {
        Console.Write("Enter number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        int columns = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[rows, columns];

        Console.WriteLine("Enter elements of the matrix:");
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < columns; c++)
            {
                Console.Write($"Element [{r},{c}]: ");
                matrix[r, c] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int[] array = new int[rows * columns];
        int index = 0;

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < columns; c++)
            {
                array[index] = matrix[r, c];
                index++;
            }
        }

        Console.Write("Flattened 1D Array: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
