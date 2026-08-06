namespace System
{
    abstract class Employ
    {
        protected String name;
        protected int id;

        public Employ(String name,int id)
        {
            this.name=name;
            this.id=id;
        }

        public void Details()
        {
            Console.WriteLine("Name is "+name + " Employ id is "+ id);
        }

        public abstract int Salary();
        
    }

    class FullTimeEmploy : Employ
    {
        public int inHand;
        public FullTimeEmploy(String name,int id,int inHand) : base(name, id)
        {
            this.inHand=inHand;
        }

        public override int Salary()
        {
            return inHand;
        }
        
    }

    class PartTimeEmploy : Employ
    {
        int hourdWorked;
        int hourPay;
        public PartTimeEmploy(String name,int id,int hourdWorked,int hourPay):base(name,id)
        {
            this.hourdWorked=hourdWorked;
            this.hourPay=hourPay;
        }

        public override int Salary()
        {
            return hourdWorked*hourPay;
        } 

    }


    class Hello
    {
        public static void Run()
        {

            Employ e1=new FullTimeEmploy("Yash",101,25000);
            Employ e2=new PartTimeEmploy("Aditya",102,50,1000);

           e1.Details();
           Console.WriteLine("Salary is "+e1.Salary()); 

            Console.WriteLine("--------------------------------");

            e2.Details();
           Console.WriteLine("Salary is "+e2.Salary());
            
        }
    }
}