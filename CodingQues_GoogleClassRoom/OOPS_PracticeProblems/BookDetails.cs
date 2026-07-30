namespace CalculatorProblems;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }

    public Book(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("\n--- Book Details ---");
        Console.WriteLine($"Title  : {Title}");
        Console.WriteLine($"Author : {Author}");
        Console.WriteLine($"Price  : {Price}");
    }
}

public class BookDetails
{
    public static void Run()
    {
        Console.Write("Enter Book Title: ");
        string title = Console.ReadLine() ?? "";

        Console.Write("Enter Author Name: ");
        string author = Console.ReadLine() ?? "";

        Console.Write("Enter Book Price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        Book book = new Book(title, author, price);
        book.DisplayDetails();
    }
}
