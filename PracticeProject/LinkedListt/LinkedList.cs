namespace LinkedListt;
public class LinkedList
{
    public Node First { get; set; }
    
    public void InsertFirst(int data) //0(1)
    {
        Node newNode = new Node();
        newNode.Data = data;
        newNode.Next = First;
        First = newNode;
    }
    
    public void InsertLast(int data)
    {
        Node newNode = new Node();
        newNode.Data = data;
        if (First == null)
        {
            First = newNode;
            return;
        }

        Node current = First;

        while (current.Next != null)
        {
            current = current.Next;
        }

        current.Next = newNode;
    }
    
    public void DeleteFirst()
    {
        if (First == null)
        {
            Console.WriteLine("List is empty");
            return;
        }

        First = First.Next;
    }

    public void Display()
    {
        Node curr = First;
        while (curr!= null)
        {
            curr.DisplayNode();
            curr = curr.Next;
        }
        Console.WriteLine();
    }
    
    
}