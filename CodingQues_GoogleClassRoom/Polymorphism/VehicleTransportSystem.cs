namespace CalculatorProblems;

public class TransVehicle
{
    public int MaxSpeed { get; set; }
    public string FuelType { get; set; }

    public TransVehicle(int maxSpeed, string fuelType)
    {
        MaxSpeed = maxSpeed;
        FuelType = fuelType;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Vehicle Max Speed: {MaxSpeed} km/h, Fuel: {FuelType}");
    }
}

public class TransCar : TransVehicle
{
    public int SeatCapacity { get; set; }

    public TransCar(int maxSpeed, string fuelType, int seatCapacity) : base(maxSpeed, fuelType)
    {
        SeatCapacity = seatCapacity;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Car - Speed: {MaxSpeed} km/h, Fuel: {FuelType}, Seats: {SeatCapacity}");
    }
}

public class TransTruck : TransVehicle
{
    public int PayloadCapacity { get; set; }

    public TransTruck(int maxSpeed, string fuelType, int payloadCapacity) : base(maxSpeed, fuelType)
    {
        PayloadCapacity = payloadCapacity;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Truck - Speed: {MaxSpeed} km/h, Fuel: {FuelType}, Payload: {PayloadCapacity} tons");
    }
}

public class TransMotorcycle : TransVehicle
{
    public bool HasSidecar { get; set; }

    public TransMotorcycle(int maxSpeed, string fuelType, bool hasSidecar) : base(maxSpeed, fuelType)
    {
        HasSidecar = hasSidecar;
    }

    public override void DisplayInfo()
    {
        string sidecarStr = HasSidecar ? "Yes" : "No";
        Console.WriteLine($"Motorcycle - Speed: {MaxSpeed} km/h, Fuel: {FuelType}, Sidecar: {sidecarStr}");
    }
}

public class VehicleTransportSystem
{
    public static void Run()
    {
        Console.WriteLine("--- Vehicle Transport System ---");

        TransVehicle[] fleet = new TransVehicle[]
        {
            new TransCar(200, "Petrol", 5),
            new TransTruck(120, "Diesel", 15),
            new TransMotorcycle(180, "Petrol", false)
        };

        foreach (TransVehicle vehicle in fleet)
        {
            vehicle.DisplayInfo();
        }
    }
}
