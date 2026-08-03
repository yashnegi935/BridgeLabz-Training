namespace CalculatorProblems;

public class SmartDevice
{
    public string DeviceId { get; set; }
    public string Status { get; set; }

    public SmartDevice(string deviceId, string status)
    {
        DeviceId = deviceId;
        Status = status;
    }
}

public class SmartThermostat : SmartDevice
{
    public double TemperatureSetting { get; set; }

    public SmartThermostat(string deviceId, string status, double temperatureSetting)
        : base(deviceId, status)
    {
        TemperatureSetting = temperatureSetting;
    }

    public void DisplayStatus()
    {
        Console.WriteLine($"Thermostat [{DeviceId}] Status: {Status}, Temperature: {TemperatureSetting}°C");
    }
}

public class SmartHomeDevice
{
    public static void Run()
    {
        Console.WriteLine("--- Single Inheritance: Smart Home Device ---");

        SmartThermostat thermostat = new SmartThermostat("DEV-TH-99", "Active", 22.5);
        thermostat.DisplayStatus();
    }
}
