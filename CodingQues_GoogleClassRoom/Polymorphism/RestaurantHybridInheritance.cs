namespace CalculatorProblems;

public interface IRestWorker
{
    void PerformDuties();
}

public class RestPerson
{
    public string Name { get; set; }
    public int Id { get; set; }

    public RestPerson(string name, int id)
    {
        Name = name;
        Id = id;
    }
}

public class RestChef : RestPerson, IRestWorker
{
    public string CuisineSpecialty { get; set; }

    public RestChef(string name, int id, string cuisineSpecialty) : base(name, id)
    {
        CuisineSpecialty = cuisineSpecialty;
    }

    public void PerformDuties()
    {
        Console.WriteLine($"Chef {Name} (ID: {Id}) is preparing {CuisineSpecialty} dishes.");
    }
}

public class RestWaiter : RestPerson, IRestWorker
{
    public int AssignedTables { get; set; }

    public RestWaiter(string name, int id, int assignedTables) : base(name, id)
    {
        AssignedTables = assignedTables;
    }

    public void PerformDuties()
    {
        Console.WriteLine($"Waiter {Name} (ID: {Id}) is serving {AssignedTables} tables.");
    }
}

public class RestaurantHybridInheritance
{
    public static void Run()
    {
        Console.WriteLine("--- Hybrid Inheritance: Restaurant Staff ---");

        List<IRestWorker> staff = new List<IRestWorker>
        {
            new RestChef("Mario", 101, "Italian"),
            new RestWaiter("Luigi", 102, 5)
        };

        foreach (var worker in staff)
        {
            worker.PerformDuties();
        }
    }
}
