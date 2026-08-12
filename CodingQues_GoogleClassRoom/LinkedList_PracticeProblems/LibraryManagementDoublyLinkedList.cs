namespace CalculatorProblems;

public class LibBookNode
{
    public int BookId { get; set; }
    public string BookTitle { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public bool IsAvailable { get; set; }
    public LibBookNode? Next { get; set; }
    public LibBookNode? Prev { get; set; }

    public LibBookNode(int bookId, string bookTitle, string author, string genre, bool isAvailable = true)
    {
        BookId = bookId;
        BookTitle = bookTitle;
        Author = author;
        Genre = genre;
        IsAvailable = isAvailable;
        Next = null;
        Prev = null;
    }
}

public class LibraryDoublyLinkedList
{
    private LibBookNode? head;
    private LibBookNode? tail;

    public void AddAtBeginning(int id, string title, string author, string genre)
    {
        LibBookNode newNode = new LibBookNode(id, title, author, genre);
        if (head == null)
        {
            head = tail = newNode;
            return;
        }
        newNode.Next = head;
        head.Prev = newNode;
        head = newNode;
    }

    public void AddAtEnd(int id, string title, string author, string genre)
    {
        LibBookNode newNode = new LibBookNode(id, title, author, genre);
        if (tail == null)
        {
            head = tail = newNode;
            return;
        }
        tail.Next = newNode;
        newNode.Prev = tail;
        tail = newNode;
    }

    public bool RemoveById(int id)
    {
        LibBookNode? temp = head;
        while (temp != null)
        {
            if (temp.BookId == id)
            {
                if (temp == head)
                {
                    head = head.Next;
                    if (head != null) head.Prev = null;
                    else tail = null;
                }
                else if (temp == tail)
                {
                    tail = tail.Prev;
                    if (tail != null) tail.Next = null;
                    else head = null;
                }
                else
                {
                    temp.Prev!.Next = temp.Next;
                    temp.Next!.Prev = temp.Prev;
                }
                return true;
            }
            temp = temp.Next;
        }
        return false;
    }

    public bool UpdateAvailability(int id, bool status)
    {
        LibBookNode? temp = head;
        while (temp != null)
        {
            if (temp.BookId == id)
            {
                temp.IsAvailable = status;
                return true;
            }
            temp = temp.Next;
        }
        return false;
    }

    public void SearchByTitleOrAuthor(string query)
    {
        LibBookNode? temp = head;
        bool found = false;
        while (temp != null)
        {
            if (temp.BookTitle.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                temp.Author.Contains(query, StringComparison.OrdinalIgnoreCase))
            {
                string statusStr = temp.IsAvailable ? "Available" : "Checked Out";
                Console.WriteLine($"Match: [{temp.BookId}] {temp.BookTitle} by {temp.Author} ({temp.Genre}) - {statusStr}");
                found = true;
            }
            temp = temp.Next;
        }
        if (!found) Console.WriteLine($"No books matched query '{query}'.");
    }

    public int CountBooks()
    {
        int count = 0;
        LibBookNode? temp = head;
        while (temp != null)
        {
            count++;
            temp = temp.Next;
        }
        return count;
    }

    public void DisplayForward()
    {
        Console.WriteLine("--- Library Books (Forward) ---");
        LibBookNode? temp = head;
        while (temp != null)
        {
            string statusStr = temp.IsAvailable ? "Available" : "Checked Out";
            Console.WriteLine($"ID: {temp.BookId}, Title: '{temp.BookTitle}', Author: {temp.Author}, Genre: {temp.Genre}, Status: {statusStr}");
            temp = temp.Next;
        }
    }

    public void DisplayReverse()
    {
        Console.WriteLine("--- Library Books (Reverse) ---");
        LibBookNode? temp = tail;
        while (temp != null)
        {
            string statusStr = temp.IsAvailable ? "Available" : "Checked Out";
            Console.WriteLine($"ID: {temp.BookId}, Title: '{temp.BookTitle}', Author: {temp.Author}, Genre: {temp.Genre}, Status: {statusStr}");
            temp = temp.Prev;
        }
    }
}

public class LibraryManagementDoublyLinkedList
{
    public static void Run()
    {
        Console.WriteLine("--- Doubly Linked List: Library Management System ---");

        LibraryDoublyLinkedList library = new LibraryDoublyLinkedList();
        library.AddAtBeginning(1, "The Hobbit", "J.R.R. Tolkien", "Fantasy");
        library.AddAtEnd(2, "1984", "George Orwell", "Dystopian");
        library.AddAtEnd(3, "Animal Farm", "George Orwell", "Satire");

        library.DisplayForward();
        Console.WriteLine($"Total Books in Library: {library.CountBooks()}");

        Console.WriteLine("\nSearching for 'Orwell'...");
        library.SearchByTitleOrAuthor("Orwell");

        Console.WriteLine("\nUpdating Book ID 2 status to Checked Out...");
        library.UpdateAvailability(2, false);

        Console.WriteLine();
        library.DisplayReverse();
    }
}
