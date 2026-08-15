using System;
using System.Linq;
using System.Text.RegularExpressions;

var employees = Data.Employees;
var departments = Data.Departments;

//var result =employees.Where(e=>e.Salary>70000);
//var result = employees.Where(e => e.Age > 27);
//var result = employees.Where(e => e.Salary > 70000 && e.Salary < 90000);
//var result = employees.Select(e => new { Name = e.Name, department=e.Department });
//var result = employees.Where(e => e.Salary > 80000)
//    .Select(e => new {e.Name ,e.Department} );

//var result = employees.FirstOrDefault(e => e.Name == "Yashhhhh");

//Console.WriteLine(result is null);
    

//foreach(var v in result)
//{
//    Console.WriteLine($"{v.Name} --> {v.Department}");
//}

//foreach (var v in result)
//{
//    Console.WriteLine($"{v.Name}--->{v.department}");
//}




string text = "12yu3fg";
bool result = Regex.IsMatch(text, @"fg");

Console.WriteLine(result);