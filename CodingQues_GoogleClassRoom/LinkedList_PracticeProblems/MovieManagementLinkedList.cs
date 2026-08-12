namespace CalculatorProblems;

public class MovieNode
{
    public string Title { get; set; }
    public string Director { get; set; }
    public int Year { get; set; }
    public double Rating { get; set; }
    public MovieNode? Next { get; set; }
    public MovieNode? Prev { get; set; }

    public MovieNode(string title, string director, int year, double rating)
    {
        Title = title;
        Director = director;
        Year = year;
        Rating = rating;
        Next = null;
        Prev = null;
    }
}

public class MovieDoublyLinkedList
{
    private MovieNode? head;
    private MovieNode? tail;

    public void AddAtBeginning(string title, string director, int year, double rating)
    {
        MovieNode newNode = new MovieNode(title, director, year, rating);
        if (head == null)
        {
            head = tail = newNode;
            return;
        }
        newNode.Next = head;
        head.Prev = newNode;
        head = newNode;
    }

    public void AddAtEnd(string title, string director, int year, double rating)
    {
        MovieNode newNode = new MovieNode(title, director, year, rating);
        if (tail == null)
        {
            head = tail = newNode;
            return;
        }
        tail.Next = newNode;
        newNode.Prev = tail;
        tail = newNode;
    }

    public void AddAtPosition(int position, string title, string director, int year, double rating)
    {
        if (position <= 1 || head == null)
        {
            AddAtBeginning(title, director, year, rating);
            return;
        }
        MovieNode temp = head;
        for (int i = 1; i < position - 1 && temp.Next != null; i++)
        {
            temp = temp.Next;
        }
        if (temp == tail)
        {
            AddAtEnd(title, director, year, rating);
            return;
        }
        MovieNode newNode = new MovieNode(title, director, year, rating);
        newNode.Next = temp.Next;
        newNode.Prev = temp;
        if (temp.Next != null)
        {
            temp.Next.Prev = newNode;
        }
        temp.Next = newNode;
    }

    public bool RemoveByTitle(string title)
    {
        MovieNode? temp = head;
        while (temp != null)
        {
            if (temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
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

    public void SearchByDirectorOrRating(string? director, double rating = -1)
    {
        MovieNode? temp = head;
        bool found = false;
        while (temp != null)
        {
            if ((director != null && temp.Director.Equals(director, StringComparison.OrdinalIgnoreCase)) ||
                (rating >= 0 && Math.Abs(temp.Rating - rating) < 0.01))
            {
                Console.WriteLine($"Match Found: {temp.Title} ({temp.Year}) by {temp.Director}, Rating: {temp.Rating}");
                found = true;
            }
            temp = temp.Next;
        }
        if (!found) Console.WriteLine("No matching movies found.");
    }

    public bool UpdateRating(string title, double newRating)
    {
        MovieNode? temp = head;
        while (temp != null)
        {
            if (temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                temp.Rating = newRating;
                return true;
            }
            temp = temp.Next;
        }
        return false;
    }

    public void DisplayForward()
    {
        Console.WriteLine("--- Movies (Forward Order) ---");
        MovieNode? temp = head;
        while (temp != null)
        {
            Console.WriteLine($"{temp.Title} ({temp.Year}) | Director: {temp.Director} | Rating: {temp.Rating}");
            temp = temp.Next;
        }
    }

    public void DisplayReverse()
    {
        Console.WriteLine("--- Movies (Reverse Order) ---");
        MovieNode? temp = tail;
        while (temp != null)
        {
            Console.WriteLine($"{temp.Title} ({temp.Year}) | Director: {temp.Director} | Rating: {temp.Rating}");
            temp = temp.Prev;
        }
    }
}

public class MovieManagementLinkedList
{
    public static void Run()
    {
        Console.WriteLine("--- Doubly Linked List: Movie Management System ---");

        MovieDoublyLinkedList list = new MovieDoublyLinkedList();
        list.AddAtBeginning("Inception", "Christopher Nolan", 2010, 8.8);
        list.AddAtEnd("Interstellar", "Christopher Nolan", 2014, 8.6);
        list.AddAtEnd("The Dark Knight", "Christopher Nolan", 2008, 9.0);
        list.AddAtPosition(2, "Avatar", "James Cameron", 2009, 7.8);

        list.DisplayForward();
        Console.WriteLine();
        list.DisplayReverse();

        Console.WriteLine("\nSearching movies by Director 'Christopher Nolan'...");
        list.SearchByDirectorOrRating("Christopher Nolan");

        Console.WriteLine("\nUpdating Avatar Rating to 8.1...");
        list.UpdateRating("Avatar", 8.1);

        Console.WriteLine("\nRemoving 'Interstellar'...");
        list.RemoveByTitle("Interstellar");

        Console.WriteLine();
        list.DisplayForward();
    }
}
