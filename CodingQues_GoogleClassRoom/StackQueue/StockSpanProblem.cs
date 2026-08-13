namespace CalculatorProblems;

public class StockSpanCalculator
{
    public static int[] CalculateSpan(int[] prices)
    {
        int n = prices.Length;
        int[] span = new int[n];
        Stack<int> indexStack = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            while (indexStack.Count > 0 && prices[indexStack.Peek()] <= prices[i])
            {
                indexStack.Pop();
            }

            span[i] = (indexStack.Count == 0) ? (i + 1) : (i - indexStack.Peek());
            indexStack.Push(i);
        }

        return span;
    }
}

public class StockSpanProblem
{
    public static void Run()
    {
        Console.WriteLine("--- Stock Span Problem ---");

        int[] prices = { 100, 80, 60, 70, 60, 75, 85 };
        int[] spans = StockSpanCalculator.CalculateSpan(prices);

        Console.WriteLine("Prices: " + string.Join(", ", prices));
        Console.WriteLine("Spans : " + string.Join(", ", spans));
    }
}
