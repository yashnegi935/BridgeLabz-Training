using System;
namespace FirstProgram
{
    class Animal
    {

        String name;
        string gender;

        public Animal(String name,string gender)
        {
            this.name=name;
            this.gender=gender;
            
        }
        private Animal()
        {
            
        }
     public void Display()
    {
    Console.WriteLine($"Name: {name}");
    Console.WriteLine($"Gender: {gender}");
    }

    public static void type()
        {
            Console.WriteLine("mamals");
        }
        
    }

    class PrivateConstructor
    {
        public static void Run()
        {
            Animal a=new Animal("dog","female");
            a.Display();
            Animal.type(); 

            
        }
    }
}