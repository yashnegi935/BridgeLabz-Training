using System;
namespace FirstProgram
{
       class Person
    {
        public static string name;
        public static string age;

        public static int height;

        public Person()
        {
            Console.WriteLine("Hello From Default Constructor");
        }

        static Person()
        {
           name="aditya";
           age="21";
           Console.WriteLine("Hello From Static constructor"); 
        }

        public static void Details()
        {
            Console.WriteLine("Name is "+name+" age is "+ age);
        }
        
    }

    public class StaticConstructor
    {
        public static void Run()
        {
            Person p=new Person();
            Person.Details();

         


            
        }
    }
}