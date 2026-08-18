namespace LinkedListt;

public class Node
{
    public int Data { get; set; }   
    public Node Next { get; set; }

    public void DisplayNode()
    {
        Console.WriteLine(Data);
    }
    
}