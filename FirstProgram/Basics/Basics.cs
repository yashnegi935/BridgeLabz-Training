using System;

namespace FirstProgram
{
    public class Basics
    {
        public static void Run()
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello Yash!");

            int age = 23;

            Console.WriteLine(age);

            float negative = -3232.337778F;
            Console.WriteLine(negative);

            Console.WriteLine(float.MaxValue);

            string name = "naman";
            Console.WriteLine("Your Name is " + name);

            int max = int.MaxValue;
            Console.WriteLine(max);

            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");

            string text = "-23";
            int convertedAge = Convert.ToInt32(text);
            Console.WriteLine(convertedAge);

            string university = "Chitkara";
            university += " University";
            Console.WriteLine(university);

            Console.Write("Enter your name: ");
            string? userName = Console.ReadLine();

            Console.Write("Enter age: ");
            string? ageInput = Console.ReadLine();

            int userAge = Convert.ToInt32(ageInput);

            if (userAge > 18)
            {
                Console.WriteLine(userName + " You Are Eligible To Vote");
            }
            else
            {
                Console.WriteLine(userName + " You Are Not Eligible To Vote");
            }

            Console.Write("Enter The Day: ");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("Wednesday");
                    break;

                case 4:
                    Console.WriteLine("Thursday");
                    break;

                case 5:
                    Console.WriteLine("Friday");
                    break;

                case 6:
                    Console.WriteLine("Saturday");
                    break;

                case 7:
                    Console.WriteLine("Sunday");
                    break;

                default:
                    Console.WriteLine("Invalid");
                    break;
            }

            double val = 21D / 2.23D;

            Console.WriteLine(val);
            Console.WriteLine(string.Format("{0:0}", val));
            Console.WriteLine(string.Format("{0:0.0}", val));
            Console.WriteLine(string.Format("{0:0.00}", val));

            Console.Write("Enter a Number: ");
            string? input = Console.ReadLine();

            bool success = int.TryParse(input, out int num);

            if (success)
            {
                Console.WriteLine("Valid " + num);
            }
            else
            {
                Console.WriteLine("Invalid Conversion");
            }
        }
    }
}