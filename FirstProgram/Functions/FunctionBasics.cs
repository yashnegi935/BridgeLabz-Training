using System;
namespace FirstProgram
{
    public class FunctionBasics
    {

        static void Modify(ref int x)
        {
            x=100;
        }

        static void change(int num,out int result)
        {
            result=num*num;
            
        }

        static void greet(string name,string greeting="hello")
        {
            Console.WriteLine($"{greeting},{name}");
            
        }

        static int Sum(params int[] numbers)
        {

            int total=0;
            foreach(int n in numbers)total+=n;

            return total;
        }

        public static void Run()
        {
            int x=5;
            Modify(ref x);
            Console.WriteLine(x);

            int result;
            change(5,out result);

            Console.WriteLine(result);

            greet("yash");
            greet("aditya","hiii");

          Console.WriteLine(Sum(1, 2, 3, 4, 5)); 

           
        }
    }
}