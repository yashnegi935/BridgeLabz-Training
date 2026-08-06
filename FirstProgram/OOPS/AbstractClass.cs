using System;
namespace FirstProgram
{
    abstract class Shape
    {
    public int length;
    public int breadth;

    static Shape(){
            Console.WriteLine("Hello from static constructor");
        }

    public Shape()
        {
             Console.WriteLine("Hello From default Shape");
        }

    public Shape(int length,int breadth)
        {
            this.length=length;
            this.breadth=breadth;

            Console.WriteLine("Hello From Shape");
        }

        public static void Display()
        {
            Console.WriteLine("Display function from Shape");
        }    

        public abstract int area();
        
    }

    class Rectangle : Shape
    {
        public Rectangle(int length,int breadth): base(length,breadth)
        {
            this.length=length;
            this.breadth=breadth;

            Console.WriteLine("Hello From Rectangle");
        }
        public override int area()
        {
            return length*breadth;
        }
        
    }

    class AbstractClass
    {
        public static void Run()
        {
            Shape r=new Rectangle(5,3);
            Shape.Display();
           Console.WriteLine(r.area());           
        }
    }
}