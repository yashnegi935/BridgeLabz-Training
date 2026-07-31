namespace CalculatorProblems;

public class CarRental
{
    public string CustomerName { get; set; }
    public string CarModel { get; set; }
    public int RentalDays { get; set; }
    public double DailyRate { get; set; }

    public CarRental()
    {
        CustomerName = "Guest";
        CarModel = "Economy";
        RentalDays = 1;
        DailyRate = 50.0;
    }

    public CarRental(string customerName, string carModel, int rentalDays, double dailyRate)
    {
        CustomerName = customerName;
        CarModel = carModel;
        RentalDays = rentalDays;
        DailyRate = dailyRate;
    }

    public double CalculateTotalCost()
    {
        return RentalDays * DailyRate;
    }

    public void DisplayRentalDetails()
    {
        Console.WriteLine($"Customer: {CustomerName}, Model: {CarModel}, Days: {RentalDays}, Total Cost: {CalculateTotalCost()}");
    }
}

public class CarRentalSystem
{
    public static void Run()
    {
        Console.WriteLine("--- Car Rental System ---");

        Console.Write("Enter Customer Name: ");
        string name = Console.ReadLine() ?? "";

        Console.Write("Enter Car Model: ");
        string model = Console.ReadLine() ?? "";

        Console.Write("Enter Rental Days: ");
        int days = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Daily Rate: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        CarRental rental = new CarRental(name, model, days, rate);

        Console.WriteLine("\nRental Details:");
        rental.DisplayRentalDetails();
    }
}
