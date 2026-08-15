using System;
namespace FirstProgram
{
    class Parent
    {
        public virtual void Show()
        {
            Console.WriteLine("Hello From Parent");
        }
    }
    class Child : Parent
    {
        public override void Show()
        {
             Console.WriteLine("Hello From child");
        }
    }

    class Boy : Child
    {
         public override void Show()
        {
            // base.Show();
            Console.WriteLine("Hello From Boy");
        }
    }

    class MethodOverriding
    {
        public static void Run()
        {
          Child p=new Boy();
          p.Show();
            
        }
    }
}