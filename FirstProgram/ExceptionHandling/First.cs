using System;
namespace FirstProgram
{
    public class First
    {
        public static void Run()
        {
            Console.WriteLine("Enter a number");
            int num=Convert.ToInt32(Console.ReadLine());
            try
            {
                int x=140;
                int result=x/num;
                Console.WriteLine(result);
                if(num==4)throw new Exception("The number is not divisible by 4");
                
  
            }
          
            catch(DivideByZeroException e)
            {

                Console.WriteLine("Exception Occurded"+e.Message);

            }

              catch(Exception ex)
            {
                Console.WriteLine("My Exception"+ex.Message);
            }


            finally{
                  Console.WriteLine("All Exceptions are trapped");
            }
            
        }
    }
}