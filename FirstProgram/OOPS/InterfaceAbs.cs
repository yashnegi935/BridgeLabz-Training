using System;
namespace FirstProgram
{

    interface ICar
    {
        void Show();
        void Display();
        void Speed();
        
    }

    abstract class RacingCar:ICar
    {
        public new virtual void Show()
        {
            Console.WriteLine("Show");
        }

        public abstract void Display();

        public abstract void Speed();
        
    }

    class Toyota:RacingCar
    {

        public override void Show()
        {
            Console.WriteLine("Show from toyota");
        }
        public override void Display()
        {
            Console.WriteLine("Display");
        }

        public override void Speed()
        {
           Console.WriteLine("Speed");
        }
        
    }


  class InterfaceAbs
    {
        public static void Run()
        {
            RacingCar t=new Toyota();
            t.Display();
            t.Show();
            t.Speed();
           
        }
    }  

}