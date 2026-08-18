namespace CalculatorProblems;

public class BinarySearch2DMatrix
{
    public static bool SearchMatrix(int[,] matrix, int target, out int row, out int col)
    {
        row = -1;
        col = -1;
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        int low = 0;
        int high = rows * cols - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            int r = mid / cols;
            int c = mid % cols;

            if (matrix[r, c] == target)
            {
                row = r;
                col = c;
                return true;
            }
            else if (matrix[r, c] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return false;
    }

    public static void Run()
    {
        Console.WriteLine("--- Binary Search: 2D Matrix ---");

        int[,] matrix = new int[,]
        {
            { 1,  3,  5,  7 },
            { 10, 11, 16, 20 },
            { 23, 30, 34, 60 }
        };

        int target = 16;
        if (SearchMatrix(matrix, target, out int r, out int c))
        {
            Console.WriteLine($"Target {target} found at Matrix position [{r}, {c}]");
        }
        else
        {
            Console.WriteLine($"Target {target} not found in matrix.");
        }
    }
}
