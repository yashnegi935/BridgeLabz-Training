namespace CalculatorProblems;

public class MergeSorter
{
    public static void Sort(double[] prices, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;

            Sort(prices, left, mid);
            Sort(prices, mid + 1, right);

            Merge(prices, left, mid, right);
        }
    }

    private static void Merge(double[] prices, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        double[] leftArray = new double[n1];
        double[] rightArray = new double[n2];

        Array.Copy(prices, left, leftArray, 0, n1);
        Array.Copy(prices, mid + 1, rightArray, 0, n2);

        int i = 0, j = 0, k = left;

        while (i < n1 && j < n2)
        {
            if (leftArray[i] <= rightArray[j])
            {
                prices[k] = leftArray[i];
                i++;
            }
            else
            {
                prices[k] = rightArray[j];
                j++;
            }
            k++;
        }

        while (i < n1)
        {
            prices[k] = leftArray[i];
            i++;
            k++;
        }

        while (j < n2)
        {
            prices[k] = rightArray[j];
            j++;
            k++;
        }
    }
}

public class MergeSortBookPrices
{
    public static void Run()
    {
        Console.WriteLine("--- Merge Sort: Book Prices ---");

        double[] prices = { 29.99, 12.50, 45.00, 9.99, 19.95, 35.50 };

        Console.WriteLine("Original Book Prices: " + string.Join(", ", prices.Select(p => p.ToString("C"))));

        MergeSorter.Sort(prices, 0, prices.Length - 1);

        Console.WriteLine("Sorted Book Prices  : " + string.Join(", ", prices.Select(p => p.ToString("C"))));
    }
}
