using System;
namespace FirstProgram
{
    class Employes
    {
        int id;
        string name;
        int age;

        public Employes(int id,String name,int age)
        {
            this.id=id;
            this.name=name;
            this.age=age;
        }
         public Employes(Employes e) //coppy constructor
        {
            this.id=e.id;
            this.name=e.name;      
            this.age=e.age;
        }

        public Employes()
        {
             Console.WriteLine("Constructor of Super Class");
        }

        public void Display()
        {
            Console.WriteLine("Name is "+this.name);
            Console.WriteLine("id is "+this.id);
            Console.WriteLine("age is "+this.age);
        }

        
    }

    class Developer : Employes
    {
        String role;

        public Developer()
        {
             Console.WriteLine("Constructor of Derived Class");
        }
    }

    public class OOPS_Basics
    {
        public static void Run()
        {
            Employes p=new Employes(1,"Adi",19);
            p.Display();
            Developer d=new Developer();

            Employes p2=new Employes(p);  //coppy constructor
            p2.Display();
               
            
        }
    }
}