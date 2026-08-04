namespace CalculatorProblems;

public interface IReservable
{
    bool CheckAvailability();
    void ReserveItem(string borrowerName);
}

public abstract class AbsLibraryItem
{
    private string itemId;
    private string title;
    private string author;

    public string ItemId
    {
        get { return itemId; }
    }

    public string Title
    {
        get { return title; }
    }

    public string Author
    {
        get { return author; }
    }

    public AbsLibraryItem(string itemId, string title, string author)
    {
        this.itemId = itemId;
        this.title = title;
        this.author = author;
    }

    public abstract int GetLoanDuration();

    public virtual void GetItemDetails()
    {
        Console.WriteLine($"[{ItemId}] {Title} by {Author} (Loan Duration: {GetLoanDuration()} Days)");
    }
}

public class LibItemBook : AbsLibraryItem, IReservable
{
    private bool isAvailable = true;
    private string reservedBy = "";

    public LibItemBook(string itemId, string title, string author)
        : base(itemId, title, author)
    {
    }

    public override int GetLoanDuration()
    {
        return 14;
    }

    public bool CheckAvailability()
    {
        return isAvailable;
    }

    public void ReserveItem(string borrowerName)
    {
        if (isAvailable)
        {
            isAvailable = false;
            reservedBy = borrowerName;
            Console.WriteLine($"Book '{Title}' successfully reserved by {borrowerName}.");
        }
        else
        {
            Console.WriteLine($"Book '{Title}' is already reserved.");
        }
    }
}

public class LibItemMagazine : AbsLibraryItem
{
    public LibItemMagazine(string itemId, string title, string author)
        : base(itemId, title, author)
    {
    }

    public override int GetLoanDuration()
    {
        return 7;
    }
}

public class LibItemDVD : AbsLibraryItem, IReservable
{
    private bool isAvailable = true;
    private string reservedBy = "";

    public LibItemDVD(string itemId, string title, string director)
        : base(itemId, title, director)
    {
    }

    public override int GetLoanDuration()
    {
        return 3;
    }

    public bool CheckAvailability()
    {
        return isAvailable;
    }

    public void ReserveItem(string borrowerName)
    {
        if (isAvailable)
        {
            isAvailable = false;
            reservedBy = borrowerName;
            Console.WriteLine($"DVD '{Title}' successfully reserved by {borrowerName}.");
        }
        else
        {
            Console.WriteLine($"DVD '{Title}' is already reserved.");
        }
    }
}

public class LibraryManagementSystem
{
    public static void Run()
    {
        Console.WriteLine("--- Library Management System ---");

        List<AbsLibraryItem> items = new List<AbsLibraryItem>
        {
            new LibItemBook("B-101", "Design Patterns", "Erich Gamma"),
            new LibItemMagazine("M-202", "National Geographic", "Editorial Board"),
            new LibItemDVD("D-303", "Inception", "Christopher Nolan")
        };

        foreach (var item in items)
        {
            item.GetItemDetails();
            if (item is IReservable reservable)
            {
                reservable.ReserveItem("John Doe");
            }
        }
    }
}
