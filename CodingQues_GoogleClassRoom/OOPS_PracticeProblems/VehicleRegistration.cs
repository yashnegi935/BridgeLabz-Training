namespace CalculatorProblems;

public class Vehicle
{
    public string OwnerName { get; set; }
    public string VehicleType { get; set; }
    public static double RegistrationFee { get; private set; } = 150.00;

    public Vehicle(string ownerName, string vehicleType)
    {
        OwnerName = ownerName;
        VehicleType = vehicleType;
    }

    public void DisplayVehicleDetails()
    {
        Console.WriteLine($"Owner: {OwnerName}, Type: {VehicleType}, Registration Fee: {RegistrationFee}");
    }

    public static void UpdateRegistrationFee(double newFee)
    {
        RegistrationFee = newFee;
    }
}

public class VehicleRegistration
{
    public static void Run()
    {
        Console.WriteLine("--- Vehicle Registration ---");

        Vehicle v1 = new Vehicle("Alice", "Sedan");
        Vehicle v2 = new Vehicle("Bob", "SUV");

        Console.WriteLine("Initial Vehicle Details:");
        v1.DisplayVehicleDetails();
        v2.DisplayVehicleDetails();

        Console.WriteLine("\nUpdating Registration Fee to 200.00...");
        Vehicle.UpdateRegistrationFee(200.00);

        Console.WriteLine("\nUpdated Vehicle Details:");
        v1.DisplayVehicleDetails();
        v2.DisplayVehicleDetails();
    }
}
