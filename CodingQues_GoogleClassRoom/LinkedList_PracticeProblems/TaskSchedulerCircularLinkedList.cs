namespace CalculatorProblems;

public class TaskNode
{
    public int TaskId { get; set; }
    public string TaskName { get; set; }
    public int Priority { get; set; }
    public string DueDate { get; set; }
    public TaskNode? Next { get; set; }

    public TaskNode(int taskId, string taskName, int priority, string dueDate)
    {
        TaskId = taskId;
        TaskName = taskName;
        Priority = priority;
        DueDate = dueDate;
        Next = null;
    }
}

public class TaskCircularLinkedList
{
    private TaskNode? head;
    private TaskNode? tail;
    private TaskNode? current;

    public void AddAtBeginning(int id, string name, int priority, string dueDate)
    {
        TaskNode newNode = new TaskNode(id, name, priority, dueDate);
        if (head == null)
        {
            head = tail = current = newNode;
            newNode.Next = head;
            return;
        }
        newNode.Next = head;
        head = newNode;
        tail!.Next = head;
    }

    public void AddAtEnd(int id, string name, int priority, string dueDate)
    {
        TaskNode newNode = new TaskNode(id, name, priority, dueDate);
        if (head == null)
        {
            head = tail = current = newNode;
            newNode.Next = head;
            return;
        }
        tail!.Next = newNode;
        tail = newNode;
        tail.Next = head;
    }

    public bool RemoveById(int id)
    {
        if (head == null) return false;
        TaskNode currNode = head;
        TaskNode? prev = tail;

        do
        {
            if (currNode.TaskId == id)
            {
                if (head == tail)
                {
                    head = tail = current = null;
                }
                else
                {
                    if (currNode == head)
                    {
                        head = head.Next;
                        tail!.Next = head;
                    }
                    if (currNode == tail)
                    {
                        tail = prev;
                        tail!.Next = head;
                    }
                    if (currNode == current)
                    {
                        current = currNode.Next;
                    }
                    prev!.Next = currNode.Next;
                }
                return true;
            }
            prev = currNode;
            currNode = currNode.Next!;
        } while (currNode != head);

        return false;
    }

    public void ViewCurrentAndNext()
    {
        if (current == null)
        {
            Console.WriteLine("No current task.");
            return;
        }
        Console.WriteLine($"Current Task: [{current.TaskId}] {current.TaskName} (Priority: {current.Priority}, Due: {current.DueDate})");
        current = current.Next;
    }

    public void DisplayAll()
    {
        if (head == null)
        {
            Console.WriteLine("Task scheduler list is empty.");
            return;
        }
        TaskNode temp = head;
        Console.WriteLine("--- Circular Task Scheduler List ---");
        do
        {
            Console.WriteLine($"Task ID: {temp.TaskId}, Name: {temp.TaskName}, Priority: {temp.Priority}, Due: {temp.DueDate}");
            temp = temp.Next!;
        } while (temp != head);
    }

    public void SearchByPriority(int priority)
    {
        if (head == null) return;
        TaskNode temp = head;
        bool found = false;
        do
        {
            if (temp.Priority == priority)
            {
                Console.WriteLine($"Matched Task: [{temp.TaskId}] {temp.TaskName} (Due: {temp.DueDate})");
                found = true;
            }
            temp = temp.Next!;
        } while (temp != head);
        if (!found) Console.WriteLine($"No tasks found with priority {priority}.");
    }
}

public class TaskSchedulerCircularLinkedList
{
    public static void Run()
    {
        Console.WriteLine("--- Circular Linked List: Task Scheduler ---");

        TaskCircularLinkedList scheduler = new TaskCircularLinkedList();
        scheduler.AddAtEnd(1, "Database Backup", 1, "2026-08-15");
        scheduler.AddAtEnd(2, "Generate Payroll", 2, "2026-08-18");
        scheduler.AddAtBeginning(3, "System Health Check", 1, "2026-08-13");

        scheduler.DisplayAll();

        Console.WriteLine("\nExecuting / Advancing Tasks:");
        scheduler.ViewCurrentAndNext();
        scheduler.ViewCurrentAndNext();

        Console.WriteLine("\nSearching Priority 1 Tasks:");
        scheduler.SearchByPriority(1);

        Console.WriteLine("\nRemoving Task ID 2...");
        scheduler.RemoveById(2);

        Console.WriteLine();
        scheduler.DisplayAll();
    }
}
