// using System;

// namespace FirstProgram
// {
//     class Hospital
//     {
//         public string HName { get; set; }
//         public int DepartmentCount { get; set; }

//         public Hospital(string HName, int DepartmentCount)
//         {
//             this.HName = HName;
//             this.DepartmentCount = DepartmentCount;
//         }

//         public void AddDepartment(int d)
//         {
//             DepartmentCount += d;
//         }
//     }

//     class Doctor
//     {
//         public string DName { get; set; }
//         public int Appointments { get; set; }

//         public Doctor(string DName, int Appointments)
//         {
//             this.DName = DName;
//             this.Appointments = Appointments;
//         }

//         public int ShowAppointments()
//         {
//             return Appointments;
//         }
//     }

//     class Department
//     {
//         public string DepartmentName { get; set; }
//         public int Doctors { get; set; }

//         public Department(string DepartmentName, int Doctors)
//         {
//             this.DepartmentName = DepartmentName;
//             this.Doctors = Doctors;
//         }

//         public void AddDoctors(int d)
//         {
//             Doctors += d;
//         }

//         public void RemoveDoctors(int d)
//         {
//             Doctors -= d;
//         }
//     }

//     class Appointment
//     {
//         public int Patients { get; set; }
//     }

//     class Patient
//     {
//         public string PName { get; set; }
//     }

//     class Program
//     {
//         public static void Main()
//         {
//             Hospital hospital = new Hospital("Apollo", 5);

//             Department department = new Department("Cardiology", 10);

//             Doctor doctor = new Doctor("Yash", 4);

//             Patient patient = new Patient
//             {
//                 PName = "Rahul"
//             };

//             Console.WriteLine(hospital.HName);
//             Console.WriteLine(hospital.DepartmentCount);

//             department.AddDoctors(2);
//             Console.WriteLine(department.Doctors);

//             Console.WriteLine(doctor.ShowAppointments());

//             Console.WriteLine(patient.PName);
//         }
//     }
// }