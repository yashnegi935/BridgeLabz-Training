namespace CalculatorProblems;

public class BookAccess
{
    public string ISBN;
    protected string Title;
    private string author;

    public BookAccess(string isbn, string title, string author)
    {
        ISBN = isbn;
        Title = title;
        this.author = author;
    }

    public string GetAuthor()
    {
        return author;
    }

    public void SetAuthor(string newAuthor)
    {
        author = newAuthor;
    }
}

public class EBook : BookAccess
{
    public double FileSizeMB { get; set; }

    public EBook(string isbn, string title, string author, double fileSizeMB)
        : base(isbn, title, author)
    {
        FileSizeMB = fileSizeMB;
    }

    public void DisplayEBookInfo()
    {
        Console.WriteLine($"ISBN (Public): {ISBN}");
        Console.WriteLine($"Title (Protected): {Title}");
        Console.WriteLine($"Author (Private via Getter): {GetAuthor()}");
        Console.WriteLine($"File Size: {FileSizeMB} MB");
    }
}

public class BookLibrarySystem
{
    public static void Run()
    {
        Console.WriteLine("--- Book Library System ---");

        EBook ebook = new EBook("978-3-16-148410-0", "C# Deep Dive", "Robert Martin", 15.4);
        ebook.DisplayEBookInfo();

        Console.WriteLine("\nModifying Author name via setter...");
        ebook.SetAuthor("Uncle Bob");
        Console.WriteLine($"Updated Author: {ebook.GetAuthor()}");
    }
}
