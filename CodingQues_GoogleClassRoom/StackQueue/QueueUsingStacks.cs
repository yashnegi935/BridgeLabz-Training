namespace CalculatorProblems;

public class MyQueueUsingStacks<T>
{
    private Stack<T> stackEnqueue = new Stack<T>();
    private Stack<T> stackDequeue = new Stack<T>();

    public void Enqueue(T item)
    {
        stackEnqueue.Push(item);
    }

    public T Dequeue()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty.");
        }
        ShiftStacks();
        return stackDequeue.Pop();
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty.");
        }
        ShiftStacks();
        return stackDequeue.Peek();
    }

    public bool IsEmpty()
    {
        return stackEnqueue.Count == 0 && stackDequeue.Count == 0;
    }

    public int Count
    {
        get { return stackEnqueue.Count + stackDequeue.Count; }
    }

    private void ShiftStacks()
    {
        if (stackDequeue.Count == 0)
        {
            while (stackEnqueue.Count > 0)
            {
                stackDequeue.Push(stackEnqueue.Pop());
            }
        }
    }
}

public class QueueUsingStacks
{
    public static void Run()
    {
        Console.WriteLine("--- Implement a Queue Using Two Stacks ---");

        MyQueueUsingStacks<int> queue = new MyQueueUsingStacks<int>();
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        Console.WriteLine($"Dequeued: {queue.Dequeue()}");
        Console.WriteLine($"Front Element: {queue.Peek()}");

        queue.Enqueue(40);
        queue.Enqueue(50);

        while (!queue.IsEmpty())
        {
            Console.WriteLine($"Dequeued: {queue.Dequeue()}");
        }
    }
}
