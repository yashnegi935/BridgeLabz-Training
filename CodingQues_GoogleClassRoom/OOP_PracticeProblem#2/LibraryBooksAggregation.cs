namespace CalculatorProblems;

public class AggBook
{
    public string Title { get; set; }
    public string Author { get; set; }

    public AggBook(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public void Display()
    {
        Console.WriteLine($"Book: {Title} by {Author}");
    }
}

public class AggLibrary
{
    public string Name { get; set; }
    public List<AggBook> Books { get; set; }

    public AggLibrary(string name)
    {
        Name = name;
        Books = new List<AggBook>();
    }

    public void AddBook(AggBook book)
    {
        Books.Add(book);
    }

    public void DisplayLibraryBooks()
    {
        Console.WriteLine($"--- Library: {Name} ---");
        if (Books.Count == 0)
        {
            Console.WriteLine("No books in library.");
            return;
        }

        foreach (var book in Books)
        {
            book.Display();
        }
    }
}

public class LibraryBooksAggregation
{
    public static void Run()
    {
        AggBook b1 = new AggBook("1984", "George Orwell");
        AggBook b2 = new AggBook("To Kill a Mockingbird", "Harper Lee");
        AggBook b3 = new AggBook("The Great Gatsby", "F. Scott Fitzgerald");

        AggLibrary centralLib = new AggLibrary("Central Library");
        AggLibrary cityLib = new AggLibrary("City Library");

        centralLib.AddBook(b1);
        centralLib.AddBook(b2);

        cityLib.AddBook(b2);
        cityLib.AddBook(b3);

        centralLib.DisplayLibraryBooks();
        Console.WriteLine();
        cityLib.DisplayLibraryBooks();

        Console.WriteLine("\nIndependent Book Existence:");
        b2.Display();
    }
}
