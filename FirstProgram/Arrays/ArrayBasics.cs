using System;
namespace FirstProgram
{
    public class ArrayBasics
    {
        public static void Run()
        {

        int []arr=new int[5];
        for(int i = 0; i < arr.Length; i++) {
                Console.WriteLine("Enter a number");
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            
            Array.Sort(arr);

            Array.Reverse(arr);

            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }

            int x=5;

            int position=Array.IndexOf(arr,x);
            Console.WriteLine(position);


            
        }
    }
}
