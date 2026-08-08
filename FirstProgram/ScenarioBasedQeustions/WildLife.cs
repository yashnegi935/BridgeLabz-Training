using System;
namespace FirstProgram
{
    public interface IFlyable
    {
        void Fly();
    } 
    public interface ISwimable
    {
        void Swim();
    }

    public abstract class Bird{
        public string name{get; set;}
        public Bird(String name)
        {
            this.name=name;
        }

        public void Display()
        {
            Console.WriteLine("Name of bird is "+name);
        }
        
    }

    public class Eagle : Bird, IFlyable
    {
        public Eagle(String name) : base(name)
        {
            
        }

        public void Fly()
        {
            Console.WriteLine("Eagle can Fly");
        }
        
    }

    public class Seagull : Bird, IFlyable, ISwimable
    {
        public Seagull(string name) : base(name)
        {
            
        }

        public void Fly()
        {
            Console.WriteLine("Seagull can Fly");
        }

         public void Swim()
        {
            Console.WriteLine("Seagull can Swim");
        }
        
    }

    class WildLife
    {
        public static void Run()
        {
            Bird[] birds =
            {
                new Eagle("Golden Eagle"),
                new Seagull("Sea gull")
            };

            foreach(Bird bird in birds){
                bird.Display();
                 if (bird is IFlyable flyable)
                {
                    flyable.Fly();
                }
                if (bird is ISwimable swimable)
                {
                    swimable.Swim();
                }
             Console.WriteLine("----------------");
            }
        }
    }
}