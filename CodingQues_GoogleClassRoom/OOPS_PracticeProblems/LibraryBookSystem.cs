namespace CalculatorProblems;

public class LibraryBook
{
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }
    public bool IsAvailable { get; set; }

    public LibraryBook(string title, string author, double price, bool isAvailable)
    {
        Title = title;
        Author = author;
        Price = price;
        IsAvailable = isAvailable;
    }

    public void BorrowBook()
    {
        if (IsAvailable)
        {
            IsAvailable = false;
            Console.WriteLine($"You have successfully borrowed '{Title}'.");
        }
        else
        {
            Console.WriteLine($"Sorry, '{Title}' is currently unavailable.");
        }
    }

    public void DisplayDetails()
    {
        string status = IsAvailable ? "Available" : "Not Available";
        Console.WriteLine($"Title: {Title}, Author: {Author}, Price: {Price:C}, Status: {status}");
    }
}

public class LibraryBookSystem
{
    public static void Run()
    {
        Console.WriteLine("--- Library Book System ---");

        Console.Write("Enter Book Title: ");
        string title = Console.ReadLine() ?? "";

        Console.Write("Enter Author: ");
        string author = Console.ReadLine() ?? "";

        Console.Write("Enter Price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        LibraryBook book = new LibraryBook(title, author, price, true);

        Console.WriteLine("\nInitial Book State:");
        book.DisplayDetails();

        Console.WriteLine("\nBorrowing book...");
        book.BorrowBook();

        Console.WriteLine("\nBook State after borrowing:");
        book.DisplayDetails();

        Console.WriteLine("\nAttempting to borrow again...");
        book.BorrowBook();
    }
}
