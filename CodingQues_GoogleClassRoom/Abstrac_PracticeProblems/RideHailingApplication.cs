namespace CalculatorProblems;

public interface IGPS
{
    string GetCurrentLocation();
    void UpdateLocation(string location);
}

public abstract class AbsRideVehicle
{
    private string vehicleId;
    private string driverName;
    private double ratePerKm;

    public string VehicleId
    {
        get { return vehicleId; }
    }

    public string DriverName
    {
        get { return driverName; }
    }

    public double RatePerKm
    {
        get { return ratePerKm; }
        protected set { ratePerKm = value; }
    }

    public AbsRideVehicle(string vehicleId, string driverName, double ratePerKm)
    {
        this.vehicleId = vehicleId;
        this.driverName = driverName;
        this.ratePerKm = ratePerKm;
    }

    public abstract double CalculateFare(double distance);

    public virtual void GetVehicleDetails()
    {
        Console.WriteLine($"Vehicle ID: {VehicleId}, Driver: {DriverName}, Rate/km: {RatePerKm:C}");
    }
}

public class RideCar : AbsRideVehicle, IGPS
{
    private string currentLocation = "Base Location";

    public RideCar(string vehicleId, string driverName, double ratePerKm)
        : base(vehicleId, driverName, ratePerKm)
    {
    }

    public override double CalculateFare(double distance)
    {
        return (distance * RatePerKm) + 5.0;
    }

    public string GetCurrentLocation()
    {
        return currentLocation;
    }

    public void UpdateLocation(string location)
    {
        currentLocation = location;
    }
}

public class RideBike : AbsRideVehicle, IGPS
{
    private string currentLocation = "Base Location";

    public RideBike(string vehicleId, string driverName, double ratePerKm)
        : base(vehicleId, driverName, ratePerKm)
    {
    }

    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm;
    }

    public string GetCurrentLocation()
    {
        return currentLocation;
    }

    public void UpdateLocation(string location)
    {
        currentLocation = location;
    }
}

public class RideAuto : AbsRideVehicle, IGPS
{
    private string currentLocation = "Base Location";

    public RideAuto(string vehicleId, string driverName, double ratePerKm)
        : base(vehicleId, driverName, ratePerKm)
    {
    }

    public override double CalculateFare(double distance)
    {
        return (distance * RatePerKm) + 2.0;
    }

    public string GetCurrentLocation()
    {
        return currentLocation;
    }

    public void UpdateLocation(string location)
    {
        currentLocation = location;
    }
}

public class RideHailingApplication
{
    public static void Run()
    {
        Console.WriteLine("--- Ride-Hailing Application ---");

        List<AbsRideVehicle> fleet = new List<AbsRideVehicle>
        {
            new RideCar("CAR-001", "John Driver", 1.50),
            new RideBike("BIKE-002", "Sam Rider", 0.75),
            new RideAuto("AUTO-003", "Raj Auto", 1.00)
        };

        double tripDistance = 12.5;

        foreach (var v in fleet)
        {
            v.GetVehicleDetails();
            Console.WriteLine($"Calculated Fare for {tripDistance} km: {v.CalculateFare(tripDistance):C}");
            if (v is IGPS gps)
            {
                gps.UpdateLocation($"Sector {v.VehicleId.Substring(0, 3)} Pickup Zone");
                Console.WriteLine($"Current Location: {gps.GetCurrentLocation()}");
            }
            Console.WriteLine();
        }
    }
}
