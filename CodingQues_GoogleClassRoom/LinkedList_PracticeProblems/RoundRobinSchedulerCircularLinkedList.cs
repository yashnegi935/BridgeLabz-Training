namespace CalculatorProblems;

public class ProcessNode
{
    public int ProcessId { get; set; }
    public int BurstTime { get; set; }
    public int RemainingTime { get; set; }
    public int Priority { get; set; }
    public int WaitingTime { get; set; }
    public int TurnaroundTime { get; set; }
    public ProcessNode? Next { get; set; }

    public ProcessNode(int processId, int burstTime, int priority)
    {
        ProcessId = processId;
        BurstTime = burstTime;
        RemainingTime = burstTime;
        Priority = priority;
        Next = null;
    }
}

public class RoundRobinSchedulerCircularLinkedList
{
    private ProcessNode? head;
    private ProcessNode? tail;

    public void AddProcess(int processId, int burstTime, int priority)
    {
        ProcessNode newNode = new ProcessNode(processId, burstTime, priority);
        if (head == null)
        {
            head = tail = newNode;
            newNode.Next = head;
            return;
        }
        tail!.Next = newNode;
        tail = newNode;
        tail.Next = head;
    }

    public void Simulate(int timeQuantum)
    {
        if (head == null)
        {
            Console.WriteLine("No processes in queue to schedule.");
            return;
        }

        Console.WriteLine($"\nStarting Round-Robin Execution (Time Quantum = {timeQuantum}):");

        int currentTime = 0;
        ProcessNode? curr = head;
        ProcessNode? prev = tail;

        List<ProcessNode> completedProcesses = new List<ProcessNode>();

        int round = 1;
        while (head != null)
        {
            Console.WriteLine($"\n--- Round {round++} ---");
            bool executedAny = false;

            ProcessNode? startNode = curr;
            do
            {
                if (curr!.RemainingTime > 0)
                {
                    executedAny = true;
                    int executeTime = Math.Min(curr.RemainingTime, timeQuantum);
                    curr.RemainingTime -= executeTime;
                    currentTime += executeTime;

                    Console.WriteLine($"Process P{curr.ProcessId} executed for {executeTime} units. Remaining: {curr.RemainingTime}");

                    if (curr.RemainingTime == 0)
                    {
                        curr.TurnaroundTime = currentTime;
                        curr.WaitingTime = curr.TurnaroundTime - curr.BurstTime;
                        completedProcesses.Add(curr);

                        Console.WriteLine($"Process P{curr.ProcessId} COMPLETED!");

                        if (head == tail)
                        {
                            head = tail = curr = null;
                            break;
                        }
                        else
                        {
                            if (curr == head) head = head.Next;
                            if (curr == tail) tail = prev;
                            prev!.Next = curr.Next;
                            curr = curr.Next;
                            continue;
                        }
                    }
                }
                prev = curr;
                curr = curr.Next;
            } while (curr != startNode && head != null);

            if (!executedAny) break;
        }

        Console.WriteLine("\n=== Scheduling Metrics Summary ===");
        double totalWait = 0, totalTurnaround = 0;
        foreach (var p in completedProcesses)
        {
            Console.WriteLine($"Process P{p.ProcessId} | Burst Time: {p.BurstTime} | Waiting Time: {p.WaitingTime} | Turnaround Time: {p.TurnaroundTime}");
            totalWait += p.WaitingTime;
            totalTurnaround += p.TurnaroundTime;
        }

        if (completedProcesses.Count > 0)
        {
            Console.WriteLine($"Average Waiting Time   : {(totalWait / completedProcesses.Count):F2}");
            Console.WriteLine($"Average Turnaround Time: {(totalTurnaround / completedProcesses.Count):F2}");
        }
    }

    public static void Run()
    {
        Console.WriteLine("--- Circular Linked List: Round Robin Scheduling Algorithm ---");

        RoundRobinSchedulerCircularLinkedList scheduler = new RoundRobinSchedulerCircularLinkedList();
        scheduler.AddProcess(1, 10, 1);
        scheduler.AddProcess(2, 5, 2);
        scheduler.AddProcess(3, 8, 1);

        scheduler.Simulate(4);
    }
}
