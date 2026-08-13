namespace CalculatorProblems;

public class SortStackHelper
{
    public static void SortStack(Stack<int> stack)
    {
        if (stack.Count == 0) return;

        int temp = stack.Pop();
        SortStack(stack);
        InsertSorted(stack, temp);
    }

    private static void InsertSorted(Stack<int> stack, int element)
    {
        if (stack.Count == 0 || stack.Peek() <= element)
        {
            stack.Push(element);
            return;
        }

        int temp = stack.Pop();
        InsertSorted(stack, element);
        stack.Push(temp);
    }
}

public class SortStackRecursion
{
    public static void Run()
    {
        Console.WriteLine("--- Sort a Stack Using Recursion ---");

        Stack<int> stack = new Stack<int>();
        stack.Push(30);
        stack.Push(-5);
        stack.Push(18);
        stack.Push(14);
        stack.Push(-3);

        Console.WriteLine("Original Stack (top to bottom): " + string.Join(", ", stack));

        SortStackHelper.SortStack(stack);

        Console.WriteLine("Sorted Stack (top to bottom): " + string.Join(", ", stack));
    }
}
