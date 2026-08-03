namespace CalculatorProblems;

public interface IRefuelable
{
    void Refuel();
}

public class HybVehicle
{
    public int MaxSpeed { get; set; }
    public string Model { get; set; }

    public HybVehicle(int maxSpeed, string model)
    {
        MaxSpeed = maxSpeed;
        Model = model;
    }
}

public class HybPetrolVehicle : HybVehicle, IRefuelable
{
    public double FuelTankCapacity { get; set; }

    public HybPetrolVehicle(int maxSpeed, string model, double fuelTankCapacity)
        : base(maxSpeed, model)
    {
        FuelTankCapacity = fuelTankCapacity;
    }

    public void Refuel()
    {
        Console.WriteLine($"Petrol Vehicle {Model} refueled up to {FuelTankCapacity} liters.");
    }
}

public class HybElectricVehicle : HybVehicle
{
    public double BatteryCapacityKWh { get; set; }

    public HybElectricVehicle(int maxSpeed, string model, double batteryCapacityKWh)
        : base(maxSpeed, model)
    {
        BatteryCapacityKWh = batteryCapacityKWh;
    }

    public void Charge()
    {
        Console.WriteLine($"Electric Vehicle {Model} charging battery ({BatteryCapacityKWh} kWh).");
    }
}

public class VehicleHybridInheritance
{
    public static void Run()
    {
        Console.WriteLine("--- Hybrid Inheritance: Vehicle Systems ---");

        HybPetrolVehicle petrolCar = new HybPetrolVehicle(210, "Mustang V8", 60.0);
        HybElectricVehicle electricCar = new HybElectricVehicle(250, "Tesla Model S", 100.0);

        petrolCar.Refuel();
        electricCar.Charge();
    }
}
