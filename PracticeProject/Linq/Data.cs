using System.Collections.Generic;
using Linq;

public static class Data
{
    public static List<Employee> Employees =
    [
        new Employee
            { Id = 1, Name = "Yash", Age = 22, Department = "IT", Salary = 60000, City = "Faridabad", Experience = 1 },
        new Employee
            { Id = 2, Name = "Aditya", Age = 18, Department = "HR", Salary = 50000, City = "Delhi", Experience = 3 },
        new Employee
            { Id = 3, Name = "Anshuman", Age = 21, Department = "IT", Salary = 90000, City = "Pathankot", Experience = 5 },
        new Employee
            { Id = 4, Name = "Mohit", Age = 25, Department = "Finance", Salary = 70000, City = "Gujrat", Experience = 2 },
        new Employee
            { Id = 5, Name = "Neha", Age = 30, Department = "HR", Salary = 80000, City = "Delhi", Experience = 7 },
        new Employee
            { Id = 6, Name = "Rohan", Age = 26, Department = "IT", Salary = 75000, City = "Bangalore", Experience = 4 },
        new Employee
        {
            Id = 7, Name = "Simran", Age = 22, Department = "Finance", Salary = 55000, City = "Delhi", Experience = 1
        },
        new Employee
            { Id = 8, Name = "Karan", Age = 35, Department = "IT", Salary = 120000, City = "Mumbai", Experience = 10 },
        new Employee
            { Id = 9, Name = "Anjali", Age = 27, Department = "HR", Salary = 65000, City = "Pune", Experience = 4 },
        new Employee
        {
            Id = 10, Name = "Vikas", Age = 24, Department = "Finance", Salary = 60000, City = "Bangalore",
            Experience = 2
        },
        new Employee
            { Id = 11, Name = "Arjun", Age = 29, Department = "IT", Salary = 95000, City = "Delhi", Experience = 6 },
        new Employee
            { Id = 12, Name = "Pooja", Age = 31, Department = "HR", Salary = 85000, City = "Mumbai", Experience = 8 }
    ];

    public static List<Department> Departments = new List<Department>
    {
        new Department { Id = 1, Name = "IT" },
        new Department { Id = 2, Name = "HR" },
        new Department { Id = 3, Name = "Finance" },
        new Department { Id = 4, Name = "Marketing" }
    };
}