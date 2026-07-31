namespace CalculatorProblems;

public class HotelBooking
{
    public string GuestName { get; set; }
    public string RoomType { get; set; }
    public int Nights { get; set; }

    public HotelBooking()
    {
        GuestName = "Default Guest";
        RoomType = "Standard";
        Nights = 1;
    }

    public HotelBooking(string guestName, string roomType, int nights)
    {
        GuestName = guestName;
        RoomType = roomType;
        Nights = nights;
    }

    public HotelBooking(HotelBooking other)
    {
        GuestName = other.GuestName;
        RoomType = other.RoomType;
        Nights = other.Nights;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Guest: {GuestName}, Room Type: {RoomType}, Nights: {Nights}");
    }
}

public class HotelBookingSystem
{
    public static void Run()
    {
        Console.WriteLine("--- Hotel Booking System ---");

        HotelBooking defaultBooking = new HotelBooking();
        Console.Write("Default Booking: ");
        defaultBooking.DisplayDetails();

        Console.Write("\nEnter Guest Name: ");
        string name = Console.ReadLine() ?? "";

        Console.Write("Enter Room Type: ");
        string type = Console.ReadLine() ?? "";

        Console.Write("Enter Nights: ");
        int nights = Convert.ToInt32(Console.ReadLine());

        HotelBooking customBooking = new HotelBooking(name, type, nights);
        Console.Write("Parameterized Booking: ");
        customBooking.DisplayDetails();

        HotelBooking copiedBooking = new HotelBooking(customBooking);
        Console.Write("Copied Booking: ");
        copiedBooking.DisplayDetails();
    }
}
