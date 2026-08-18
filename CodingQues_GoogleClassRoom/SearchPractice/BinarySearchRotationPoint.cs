namespace CalculatorProblems;

public class BinarySearchRotationPoint
{
    public static int FindRotationPointIndex(int[] arr)
    {
        int low = 0;
        int high = arr.Length - 1;

        while (low < high)
        {
            int mid = low + (high - low) / 2;

            if (arr[mid] > arr[high])
            {
                low = mid + 1;
            }
            else
            {
                high = mid;
            }
        }

        return low;
    }

    public static void Run()
    {
        Console.WriteLine("--- Binary Search: Rotation Point in Rotated Array ---");

        int[] rotatedArray = { 15, 18, 2, 3, 6, 12 };
        int minIndex = FindRotationPointIndex(rotatedArray);

        Console.WriteLine("Rotated Array: " + string.Join(", ", rotatedArray));
        Console.WriteLine($"Rotation Point Index (Smallest Element): {minIndex} (Value: {rotatedArray[minIndex]})");
    }
}
