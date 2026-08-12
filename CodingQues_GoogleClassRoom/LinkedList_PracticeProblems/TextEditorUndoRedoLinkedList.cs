namespace CalculatorProblems;

public class TextStateNode
{
    public string Content { get; set; }
    public TextStateNode? Next { get; set; }
    public TextStateNode? Prev { get; set; }

    public TextStateNode(string content)
    {
        Content = content;
        Next = null;
        Prev = null;
    }
}

public class TextEditorHistory
{
    private TextStateNode? head;
    private TextStateNode? tail;
    private TextStateNode? current;
    private int maxHistory;
    private int count;

    public TextEditorHistory(int maxHistory = 10)
    {
        this.maxHistory = maxHistory;
        count = 0;
        head = tail = current = null;
    }

    public void AddState(string newContent)
    {
        TextStateNode newNode = new TextStateNode(newContent);
        if (current != null)
        {
            current.Next = newNode;
            newNode.Prev = current;
            tail = newNode;
            current = newNode;
        }
        else
        {
            head = tail = current = newNode;
        }

        count++;
        while (count > maxHistory && head != null)
        {
            head = head.Next;
            if (head != null) head.Prev = null;
            count--;
        }
    }

    public void Undo()
    {
        if (current != null && current.Prev != null)
        {
            current = current.Prev;
            Console.WriteLine($"[Undo] Current Text: \"{current.Content}\"");
        }
        else
        {
            Console.WriteLine("[Undo] Cannot undo further.");
        }
    }

    public void Redo()
    {
        if (current != null && current.Next != null)
        {
            current = current.Next;
            Console.WriteLine($"[Redo] Current Text: \"{current.Content}\"");
        }
        else
        {
            Console.WriteLine("[Redo] Cannot redo further.");
        }
    }

    public void DisplayCurrent()
    {
        string text = current != null ? current.Content : "";
        Console.WriteLine($"Current State: \"{text}\"");
    }
}

public class TextEditorUndoRedoLinkedList
{
    public static void Run()
    {
        Console.WriteLine("--- Doubly Linked List: Text Editor Undo/Redo ---");

        TextEditorHistory editor = new TextEditorHistory(10);
        editor.AddState("Hello");
        editor.AddState("Hello World");
        editor.AddState("Hello World!");

        editor.DisplayCurrent();

        editor.Undo();
        editor.Undo();
        editor.Redo();

        editor.AddState("Hello World! Welcome.");
        editor.DisplayCurrent();
    }
}
