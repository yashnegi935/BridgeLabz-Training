using System.Text.RegularExpressions;

namespace GenericProject;

public class Check
{
    public static void display<T>(User<T> user)
    {
        Console.WriteLine("Id "+user.id);
        Console.WriteLine("Name "+user.Name);
        Console.WriteLine("email "+user.email);

        bool validEmail = Regex.IsMatch(user.email,
            @"^[a-zA-Z0-9]+@[a-zA-Z]+\.[A-Za-z]");

        bool validId = Regex.IsMatch(user.id.ToString(), @"^[0-9]{3}$");
        
        if(validId)Console.WriteLine("Id is valid");
        else Console.WriteLine("Invalid Id");
        
        if(validEmail) Console.WriteLine("Email is valid");
        else Console.WriteLine("Invalid email");

    }
    
}