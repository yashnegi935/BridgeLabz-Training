namespace CalculatorProblems;

public interface IMedicalRecord
{
    void AddRecord(string record);
    void ViewRecords();
}

public abstract class AbsPatient
{
    private int patientId;
    private string name;
    private int age;

    public int PatientId
    {
        get { return patientId; }
    }

    public string Name
    {
        get { return name; }
    }

    public int Age
    {
        get { return age; }
    }

    public AbsPatient(int patientId, string name, int age)
    {
        this.patientId = patientId;
        this.name = name;
        this.age = age;
    }

    public abstract double CalculateBill();

    public virtual void GetPatientDetails()
    {
        Console.WriteLine($"Patient ID: {PatientId}, Name: {Name}, Age: {Age}, Total Bill: {CalculateBill():C}");
    }
}

public class InPatient : AbsPatient, IMedicalRecord
{
    private List<string> medicalHistory = new List<string>();
    public int DaysStayed { get; set; }
    public double DailyRoomRate { get; set; }

    public InPatient(int patientId, string name, int age, int daysStayed, double dailyRoomRate)
        : base(patientId, name, age)
    {
        DaysStayed = daysStayed;
        DailyRoomRate = dailyRoomRate;
    }

    public override double CalculateBill()
    {
        return DaysStayed * DailyRoomRate;
    }

    public void AddRecord(string record)
    {
        medicalHistory.Add(record);
    }

    public void ViewRecords()
    {
        Console.WriteLine($"Medical History for InPatient {Name}:");
        foreach (var rec in medicalHistory)
        {
            Console.WriteLine($"- {rec}");
        }
    }
}

public class OutPatient : AbsPatient, IMedicalRecord
{
    private List<string> medicalHistory = new List<string>();
    public double ConsultationFee { get; set; }

    public OutPatient(int patientId, string name, int age, double consultationFee)
        : base(patientId, name, age)
    {
        ConsultationFee = consultationFee;
    }

    public override double CalculateBill()
    {
        return ConsultationFee;
    }

    public void AddRecord(string record)
    {
        medicalHistory.Add(record);
    }

    public void ViewRecords()
    {
        Console.WriteLine($"Medical History for OutPatient {Name}:");
        foreach (var rec in medicalHistory)
        {
            Console.WriteLine($"- {rec}");
        }
    }
}

public class HospitalPatientManagement
{
    public static void Run()
    {
        Console.WriteLine("--- Hospital Patient Management ---");

        InPatient inP = new InPatient(1001, "Grace Hopper", 45, 4, 250.0);
        inP.AddRecord("Admitted for surgery.");
        inP.AddRecord("Post-op recovery normal.");

        OutPatient outP = new OutPatient(1002, "Alan Kay", 32, 75.0);
        outP.AddRecord("Routine checkup completed.");

        List<AbsPatient> patients = new List<AbsPatient> { inP, outP };

        foreach (var p in patients)
        {
            p.GetPatientDetails();
            if (p is IMedicalRecord med)
            {
                med.ViewRecords();
            }
            Console.WriteLine();
        }
    }
}
