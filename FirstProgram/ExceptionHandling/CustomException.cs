namespace FirstProgram
{

    class InvalidNameException : Exception
    {
        public InvalidNameException(String message) : base(message)
        {
            
        }

    }

    class ValidName
    {
        public void CheckName(String name)
        {
            if(name != "Yash" && name != "Bhavishya")
            {
                throw new InvalidNameException("Invalid name only Yash and Bhavishya has accesss");
            }
            Console.WriteLine("Access Granted");
        }
        
    }

    public class CustomException
    {
        public static void Run()
        {
            ValidName validName=new ValidName();
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            try
            {
                 validName.CheckName(name);
            }
            catch (InvalidNameException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}