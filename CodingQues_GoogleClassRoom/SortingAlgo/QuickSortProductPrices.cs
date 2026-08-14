namespace CalculatorProblems;

public class QuickSorter
{
    public static void Sort(double[] prices, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(prices, low, high);

            Sort(prices, low, pivotIndex - 1);
            Sort(prices, pivotIndex + 1, high);
        }
    }

    private static int Partition(double[] prices, int low, int high)
    {
        double pivot = prices[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (prices[j] <= pivot)
            {
                i++;
                Swap(prices, i, j);
            }
        }

        Swap(prices, i + 1, high);
        return i + 1;
    }

    private static void Swap(double[] prices, int i, int j)
    {
        double temp = prices[i];
        prices[i] = prices[j];
        prices[j] = temp;
    }
}

public class QuickSortProductPrices
{
    public static void Run()
    {
        Console.WriteLine("--- Quick Sort: Product Prices ---");

        double[] productPrices = { 199.99, 49.95, 299.00, 15.00, 89.99, 120.50 };

        Console.WriteLine("Original Product Prices: " + string.Join(", ", productPrices.Select(p => p.ToString("C"))));

        QuickSorter.Sort(productPrices, 0, productPrices.Length - 1);

        Console.WriteLine("Sorted Product Prices  : " + string.Join(", ", productPrices.Select(p => p.ToString("C"))));
    }
}
