namespace CalculatorProblems;

public class HospPatient
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<HospDoctor> ConsultedDoctors { get; set; }

    public HospPatient(int id, string name)
    {
        Id = id;
        Name = name;
        ConsultedDoctors = new List<HospDoctor>();
    }
}

public class HospDoctor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Specialization { get; set; }
    public List<HospPatient> ConsultedPatients { get; set; }

    public HospDoctor(int id, string name, string specialization)
    {
        Id = id;
        Name = name;
        Specialization = specialization;
        ConsultedPatients = new List<HospPatient>();
    }

    public void Consult(HospPatient patient)
    {
        if (!ConsultedPatients.Contains(patient))
        {
            ConsultedPatients.Add(patient);
            patient.ConsultedDoctors.Add(this);
        }
        Console.WriteLine($"Dr. {Name} ({Specialization}) conducted a consultation with patient {patient.Name}.");
    }
}

public class HospHospital
{
    public string Name { get; set; }
    public List<HospDoctor> Doctors { get; set; }
    public List<HospPatient> Patients { get; set; }

    public HospHospital(string name)
    {
        Name = name;
        Doctors = new List<HospDoctor>();
        Patients = new List<HospPatient>();
    }

    public void AddDoctor(HospDoctor doctor)
    {
        Doctors.Add(doctor);
    }

    public void AddPatient(HospPatient patient)
    {
        Patients.Add(patient);
    }
}

public class HospitalDoctorPatient
{
    public static void Run()
    {
        HospHospital hospital = new HospHospital("City Care Hospital");

        HospDoctor doc1 = new HospDoctor(101, "Dr. House", "Cardiology");
        HospDoctor doc2 = new HospDoctor(102, "Dr. Watson", "Neurology");

        HospPatient pat1 = new HospPatient(201, "Mark Brown");
        HospPatient pat2 = new HospPatient(202, "Lucy Grey");

        hospital.AddDoctor(doc1);
        hospital.AddDoctor(doc2);
        hospital.AddPatient(pat1);
        hospital.AddPatient(pat2);

        doc1.Consult(pat1);
        doc1.Consult(pat2);
        doc2.Consult(pat1);

        Console.WriteLine($"\nDoctor {doc1.Name} total consultations: {doc1.ConsultedPatients.Count}");
        Console.WriteLine($"Patient {pat1.Name} total doctors consulted: {pat1.ConsultedDoctors.Count}");
    }
}
