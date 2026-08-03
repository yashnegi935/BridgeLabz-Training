namespace CalculatorProblems;

public class SingleBook
{
    public string Title { get; set; }
    public int PublicationYear { get; set; }

    public SingleBook(string title, int publicationYear)
    {
        Title = title;
        PublicationYear = publicationYear;
    }
}

public class SingleAuthor : SingleBook
{
    public string AuthorName { get; set; }
    public string Bio { get; set; }

    public SingleAuthor(string title, int publicationYear, string authorName, string bio)
        : base(title, publicationYear)
    {
        AuthorName = authorName;
        Bio = bio;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Book: '{Title}' ({PublicationYear})");
        Console.WriteLine($"Author: {AuthorName}");
        Console.WriteLine($"Bio: {Bio}");
    }
}

public class BookAuthorSingleInheritance
{
    public static void Run()
    {
        Console.WriteLine("--- Single Inheritance: Book and Author ---");

        SingleAuthor bookAuthor = new SingleAuthor("Clean Code", 2008, "Robert C. Martin", "Software Engineer and Author");
        bookAuthor.DisplayInfo();
    }
}
