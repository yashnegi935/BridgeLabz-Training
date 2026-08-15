using System;
using System.Collections.Generic;

namespace FirstProgram
{
    class Hospital
    {
        public string HName { get; set; }
        public List<Department> Departments { get; set; } = new();
    }

    class Department
    {
        public string DeparName { get; set; }
        public List<Doctor> Doctors { get; set; } = new();
    }

    class Doctor
    {
        public string DName { get; set; }
        public Department Department { get; set; }
    }

    class Patient
    {
        public string PName { get; set; }
        public List<Appointment> Appointments { get; set; } = new();
    }

    class Appointment
    {
        public Patient Patient { get; }
        public Doctor Doctor { get; }
        public Prescription Prescription { get; set; }

        public Appointment(Patient patient, Doctor doctor)
        {
            Patient = patient;
            Doctor = doctor;
        }
    }

    class Prescription
    {
        public List<Treatment> Treatments { get; set; } = new();
    }

    abstract class Treatment
    {
        public string TName { get; set; }
    }

    class Medication : Treatment
    {
        public string Dosage { get; set; }
    }

    class H
    {
        public static void Run()
        {
            Hospital hospital = new Hospital();
            Department department = new Department();
            Doctor doctor = new Doctor();
            Patient patient = new Patient();

            hospital.HName = "City Hospital";
            department.DeparName = "Cardiology";
            doctor.DName = "Dr. Rahul";
            patient.PName = "Yash";

            hospital.Departments.Add(department);
            department.Doctors.Add(doctor);

            Appointment appointment = new Appointment(patient, doctor);

            Prescription prescription = new Prescription();
            Medication medicine = new Medication();

            prescription.Treatments.Add(medicine);
            appointment.Prescription = prescription;

        Console.WriteLine(hospital.HName);
        Console.WriteLine(department.DeparName);
        Console.WriteLine(doctor.DName);
        Console.WriteLine(patient.PName);
        }
    }
}