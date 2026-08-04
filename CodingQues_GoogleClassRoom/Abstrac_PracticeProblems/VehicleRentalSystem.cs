namespace CalculatorProblems;

public interface IInsurable
{
    double CalculateInsurance();
    string GetInsuranceDetails();
}

public abstract class AbsRentalVehicle
{
    private string vehicleNumber;
    private string type;
    private double rentalRate;

    public string VehicleNumber
    {
        get { return vehicleNumber; }
        protected set { vehicleNumber = value; }
    }

    public string Type
    {
        get { return type; }
        protected set { type = value; }
    }

    public double RentalRate
    {
        get { return rentalRate; }
        protected set { rentalRate = value; }
    }

    public AbsRentalVehicle(string vehicleNumber, string type, double rentalRate)
    {
        this.vehicleNumber = vehicleNumber;
        this.type = type;
        this.rentalRate = rentalRate;
    }

    public abstract double CalculateRentalCost(int days);
}

public class RentalCar : AbsRentalVehicle, IInsurable
{
    private string policyNumber;

    public RentalCar(string vehicleNumber, double rentalRate, string policyNumber)
        : base(vehicleNumber, "Car", rentalRate)
    {
        this.policyNumber = policyNumber;
    }

    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days;
    }

    public double CalculateInsurance()
    {
        return 25.00;
    }

    public string GetInsuranceDetails()
    {
        return $"Policy #{policyNumber} (Comprehensive Auto)";
    }
}

public class RentalBike : AbsRentalVehicle
{
    public RentalBike(string vehicleNumber, double rentalRate)
        : base(vehicleNumber, "Bike", rentalRate)
    {
    }

    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days;
    }
}

public class RentalTruck : AbsRentalVehicle, IInsurable
{
    private string policyNumber;

    public RentalTruck(string vehicleNumber, double rentalRate, string policyNumber)
        : base(vehicleNumber, "Truck", rentalRate)
    {
        this.policyNumber = policyNumber;
    }

    public override double CalculateRentalCost(int days)
    {
        return (RentalRate * days) + 50.0;
    }

    public double CalculateInsurance()
    {
        return 75.00;
    }

    public string GetInsuranceDetails()
    {
        return $"Policy #{policyNumber} (Commercial Cargo)";
    }
}

public class VehicleRentalSystem
{
    public static void Run()
    {
        Console.WriteLine("--- Vehicle Rental System ---");

        List<AbsRentalVehicle> vehicles = new List<AbsRentalVehicle>
        {
            new RentalCar("CAR-101", 50.0, "POL-CAR-99"),
            new RentalBike("BIKE-202", 15.0),
            new RentalTruck("TRK-303", 120.0, "POL-TRK-77")
        };

        int rentalDays = 3;

        foreach (var v in vehicles)
        {
            double cost = v.CalculateRentalCost(rentalDays);
            double ins = (v is IInsurable insurable) ? insurable.CalculateInsurance() : 0.0;
            string insDetails = (v is IInsurable i) ? i.GetInsuranceDetails() : "No Insurance Required";

            Console.WriteLine($"Vehicle: {v.VehicleNumber} ({v.Type}) | {rentalDays} Days Rental: {cost:C} | Insurance: {ins:C} ({insDetails})");
        }
    }
}
