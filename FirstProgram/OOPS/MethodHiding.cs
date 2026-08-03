using System;
namespace FirstProgram
{

    class Animall
    {
        public void Show()
        {
            Console.WriteLine("Hello From Parent");
        }
    }

    class Dog : Animall
    {
        public new void Show()
        {
             Console.WriteLine("Hello From child");
        }
    }

    class MethodHiding
    {
        public static void Run()
        {
            Animall d=new Dog();
            Dog d2=new Dog();
            d.Show();
            ((Animall)d2).Show();
            d2.Show();
            
        }
    }
}