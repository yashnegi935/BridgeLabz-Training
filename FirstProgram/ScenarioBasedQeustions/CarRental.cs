using System;
namespace FirstProgram
{
    interface IDrivealble
    {
        void Drive();
    }
    interface IChargeable
    {
        void Charge();
    }
    public abstract class Vehicles
    {
        public string name{get;set;}
        public int id{get;set;}

        public Vehicles(string name,int id)
        {
            this.name=name;
            this.id=id;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Id Of Car Is "+id+" Name of Car is "+name);
        }
        
    }

    class Carr:Vehicles,IDrivealble
    {
        public Carr(String name,int id):base(name ,id)
        {   
        }

        public void Drive()
        {
            Console.WriteLine(name+" Car Can Drive");
        }

            
        }

    class ElectricCar:Vehicles,IChargeable,IDrivealble
    {
        public ElectricCar(String name,int id):base(name ,id)
        {   
        }

        public void Drive()
        {
            Console.WriteLine(name+" Car Can Drive");
        }

        public void Charge()
        {
             Console.WriteLine(name+" Car Support Charging");
        }
   
        }
    

    class CarRental
    {
        public static void Run()
        {
           Vehicles [] vehicles =
            {
                new Carr("EcoSports",101),
                new ElectricCar("BMW",102)
            };

            foreach(Vehicles v in vehicles)
            {
                v.DisplayDetails();
                if(v is IDrivealble drivealble)
                {
                    drivealble.Drive();
                }
                if(v is IChargeable chargeable)
                {
                    chargeable.Charge();
                }
                 Console.WriteLine("----------------");
            }
            
        }
    }
}