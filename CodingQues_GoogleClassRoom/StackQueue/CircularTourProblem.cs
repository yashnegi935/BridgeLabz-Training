namespace CalculatorProblems;

public class PetrolPump
{
    public int Petrol { get; set; }
    public int Distance { get; set; }

    public PetrolPump(int petrol, int distance)
    {
        Petrol = petrol;
        Distance = distance;
    }
}

public class CircularTourSolver
{
    public static int FindStartingPoint(PetrolPump[] pumps)
    {
        int n = pumps.Length;
        int start = 0;
        int currentPetrol = 0;
        int totalDeficit = 0;

        for (int i = 0; i < n; i++)
        {
            currentPetrol += pumps[i].Petrol - pumps[i].Distance;
            if (currentPetrol < 0)
            {
                totalDeficit += currentPetrol;
                start = i + 1;
                currentPetrol = 0;
            }
        }

        return (currentPetrol + totalDeficit >= 0) ? start : -1;
    }
}

public class CircularTourProblem
{
    public static void Run()
    {
        Console.WriteLine("--- Circular Tour Problem ---");

        PetrolPump[] pumps = new PetrolPump[]
        {
            new PetrolPump(4, 6),
            new PetrolPump(6, 5),
            new PetrolPump(7, 3),
            new PetrolPump(4, 5)
        };

        int startIndex = CircularTourSolver.FindStartingPoint(pumps);

        if (startIndex != -1)
        {
            Console.WriteLine($"Start Circular Tour at Petrol Pump Index: {startIndex}");
        }
        else
        {
            Console.WriteLine("No valid starting point for circular tour.");
        }
    }
}
