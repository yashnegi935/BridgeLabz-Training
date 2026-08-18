namespace TicketManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            TicketManager manager = new TicketManager();
            Ticket t1 = new Ticket(101, "Yash", "yashnegi935@gmail.com", "Network","open"
            );
            Ticket t2 = new Ticket(102, "Aditya", "aditya123@gamil.com", "Network","open"
            );
            manager.AddTickets(t1);
            manager.AddTickets(t2);
            manager.Displayticket();
            Console.WriteLine(manager.Count());

            Console.WriteLine(manager.GetTicket(101));
           

        }
        
    }

}