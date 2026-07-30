using System;
using System.Text;

namespace FirstProgram.Strings;

public class StringBasics
{
    public static void Run()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        string ageInput = Console.ReadLine();

        int age = Convert.ToInt32(ageInput);

        Console.WriteLine("Your name is {0} and your age is {1}", name, age);
        Console.WriteLine($"Your name is {name} and your age is {age}");

        Console.WriteLine();

        string word = "hello";

        char[] chars = { 'h', 'e', 'l', 'l', 'o' };

        string compare = new string(chars);

        if (word == compare)
            Console.WriteLine("Same");
        else
            Console.WriteLine("Different");

        Console.WriteLine();

        object a = new string("he".ToCharArray());
        object b = new string("he".ToCharArray());

        Console.WriteLine(a == b);
        Console.WriteLine(a.Equals(b));

        Console.WriteLine();

        string greeting = "Hello";

        StringBuilder sb = new StringBuilder(greeting);

        sb.AppendLine(" World");
        sb.AppendLine("C#");

        sb.Insert(1, "E");

        Console.WriteLine(sb);
    }
}