namespace CalculatorProblems;

public class MatrixOperations
{
    public static void Run()
    {
        Console.WriteLine("--- 2x2 Matrix Operations ---");
        double[,] m1 = CreateRandomMatrix(2, 2);
        double[,] m2 = CreateRandomMatrix(2, 2);

        Console.WriteLine("Matrix 1:");
        DisplayMatrix(m1);
        Console.WriteLine("Matrix 2:");
        DisplayMatrix(m2);

        Console.WriteLine("Addition:");
        DisplayMatrix(AddMatrices(m1, m2));

        Console.WriteLine("Subtraction:");
        DisplayMatrix(SubtractMatrices(m1, m2));

        Console.WriteLine("Multiplication:");
        DisplayMatrix(MultiplyMatrices(m1, m2));

        Console.WriteLine("Transpose of Matrix 1:");
        DisplayMatrix(TransposeMatrix(m1));

        double det2x2 = Determinant2x2(m1);
        Console.WriteLine($"Determinant of Matrix 1 (2x2): {det2x2}");

        double[,] inv2x2 = Inverse2x2(m1);
        if (inv2x2 != null)
        {
            Console.WriteLine("Inverse of Matrix 1 (2x2):");
            DisplayMatrix(inv2x2);
        }
        else
        {
            Console.WriteLine("Inverse of Matrix 1 does not exist (det = 0).");
        }

        Console.WriteLine("\n--- 3x3 Matrix Operations ---");
        double[,] m3 = CreateRandomMatrix(3, 3);
        Console.WriteLine("3x3 Matrix:");
        DisplayMatrix(m3);

        double det3x3 = Determinant3x3(m3);
        Console.WriteLine($"Determinant of 3x3 Matrix: {det3x3}");

        double[,] inv3x3 = Inverse3x3(m3);
        if (inv3x3 != null)
        {
            Console.WriteLine("Inverse of 3x3 Matrix:");
            DisplayMatrix(inv3x3);
        }
        else
        {
            Console.WriteLine("Inverse of 3x3 Matrix does not exist (det = 0).");
        }
    }

    public static double[,] CreateRandomMatrix(int rows, int cols)
    {
        Random random = new Random();
        double[,] matrix = new double[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = random.Next(1, 10);
            }
        }
        return matrix;
    }

    public static double[,] AddMatrices(double[,] a, double[,] b)
    {
        int rows = a.GetLength(0);
        int cols = a.GetLength(1);
        double[,] result = new double[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = a[i, j] + b[i, j];
            }
        }
        return result;
    }

    public static double[,] SubtractMatrices(double[,] a, double[,] b)
    {
        int rows = a.GetLength(0);
        int cols = a.GetLength(1);
        double[,] result = new double[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = a[i, j] - b[i, j];
            }
        }
        return result;
    }

    public static double[,] MultiplyMatrices(double[,] a, double[,] b)
    {
        int r1 = a.GetLength(0);
        int c1 = a.GetLength(1);
        int r2 = b.GetLength(0);
        int c2 = b.GetLength(1);

        if (c1 != r2) return new double[0, 0];

        double[,] result = new double[r1, c2];
        for (int i = 0; i < r1; i++)
        {
            for (int j = 0; j < c2; j++)
            {
                double sum = 0;
                for (int k = 0; k < c1; k++)
                {
                    sum += a[i, k] * b[k, j];
                }
                result[i, j] = sum;
            }
        }
        return result;
    }

    public static double[,] TransposeMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] result = new double[cols, rows];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[j, i] = matrix[i, j];
            }
        }
        return result;
    }

    public static double Determinant2x2(double[,] matrix)
    {
        return (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
    }

    public static double Determinant3x3(double[,] matrix)
    {
        double a = matrix[0, 0], b = matrix[0, 1], c = matrix[0, 2];
        double d = matrix[1, 0], e = matrix[1, 1], f = matrix[1, 2];
        double g = matrix[2, 0], h = matrix[2, 1], i = matrix[2, 2];

        return a * (e * i - f * h) - b * (d * i - f * g) + c * (d * h - e * g);
    }

    public static double[,] Inverse2x2(double[,] matrix)
    {
        double det = Determinant2x2(matrix);
        if (Math.Abs(det) < 1e-9) return null!;

        double[,] inv = new double[2, 2];
        inv[0, 0] = matrix[1, 1] / det;
        inv[0, 1] = -matrix[0, 1] / det;
        inv[1, 0] = -matrix[1, 0] / det;
        inv[1, 1] = matrix[0, 0] / det;

        for (int r = 0; r < 2; r++)
        {
            for (int c = 0; c < 2; c++)
            {
                inv[r, c] = Math.Round(inv[r, c], 4);
            }
        }

        return inv;
    }

    public static double[,] Inverse3x3(double[,] matrix)
    {
        double det = Determinant3x3(matrix);
        if (Math.Abs(det) < 1e-9) return null!;

        double a = matrix[0, 0], b = matrix[0, 1], c = matrix[0, 2];
        double d = matrix[1, 0], e = matrix[1, 1], f = matrix[1, 2];
        double g = matrix[2, 0], h = matrix[2, 1], i = matrix[2, 2];

        double[,] adj = new double[3, 3];
        adj[0, 0] = (e * i - f * h);
        adj[0, 1] = -(b * i - c * h);
        adj[0, 2] = (b * f - c * e);

        adj[1, 0] = -(d * i - f * g);
        adj[1, 1] = (a * i - c * g);
        adj[1, 2] = -(a * f - c * d);

        adj[2, 0] = (d * h - e * g);
        adj[2, 1] = -(a * h - b * g);
        adj[2, 2] = (a * e - b * d);

        double[,] inv = new double[3, 3];
        for (int r = 0; r < 3; r++)
        {
            for (int cl = 0; cl < 3; cl++)
            {
                inv[r, cl] = Math.Round(adj[r, cl] / det, 4);
            }
        }

        return inv;
    }

    public static void DisplayMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j],8:F2} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
