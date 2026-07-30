using System;
namespace FirstProgram
{
    public class Bank
    {
        public static void Run()
        {
            try
            {

             int currectSavings=10000;
            Console.WriteLine("Enter a number");
            int withdrawl=Convert.ToInt32(Console.ReadLine());

            if (currectSavings < withdrawl)
            {
                throw new Exception("Insufficient Balance");
            }
            else
            {
                currectSavings-=withdrawl;
                Console.WriteLine("Current savings are "+currectSavings);
            }
                
            }

            catch(Exception ex)
            {
             Console.WriteLine("My Exception "+ex.Message);
            }
            
        }
    }
}