using System;
namespace FirstProgram
{

interface IEnglish
    {
        void Greet();
    }

    interface IHindi
    {
        void Greet();
    }

    class Greeting:IEnglish,IHindi
    {
        void IEnglish.Greet()
        {
            Console.WriteLine("Hello");
        }

        void IHindi.Greet()
        {
         Console.WriteLine("Namaste");
        }

        public void Greet(){
          Console.WriteLine("General Greetings");
        }
        
    }

    class InterfaceImp
    {
        public static void Run()
        {
            // Greeting g=new Greeting();
            // IEnglish english=g;
            // english.Greet();

            // IHindi hindi=g;
            // hindi.Greet();

            IHindi p=new Greeting();
            p.Greet();

            IEnglish e=new Greeting();
            e.Greet();

            // g.Greet();
           
        }
        
    }
}