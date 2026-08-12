namespace CalculatorProblems;

public class TicketNode
{
    public int TicketId { get; set; }
    public string CustomerName { get; set; }
    public string MovieName { get; set; }
    public string SeatNumber { get; set; }
    public string BookingTime { get; set; }
    public TicketNode? Next { get; set; }

    public TicketNode(int ticketId, string customerName, string movieName, string seatNumber, string bookingTime)
    {
        TicketId = ticketId;
        CustomerName = customerName;
        MovieName = movieName;
        SeatNumber = seatNumber;
        BookingTime = bookingTime;
        Next = null;
    }
}

public class TicketReservationCircularLinkedList
{
    private TicketNode? head;
    private TicketNode? tail;

    public void AddTicket(int id, string customer, string movie, string seat, string time)
    {
        TicketNode newNode = new TicketNode(id, customer, movie, seat, time);
        if (head == null)
        {
            head = tail = newNode;
            newNode.Next = head;
            return;
        }
        tail!.Next = newNode;
        tail = newNode;
        tail.Next = head;
    }

    public bool RemoveTicketById(int id)
    {
        if (head == null) return false;
        TicketNode curr = head;
        TicketNode? prev = tail;

        do
        {
            if (curr.TicketId == id)
            {
                if (head == tail)
                {
                    head = tail = null;
                }
                else
                {
                    if (curr == head)
                    {
                        head = head.Next;
                        tail!.Next = head;
                    }
                    if (curr == tail)
                    {
                        tail = prev;
                        tail!.Next = head;
                    }
                    prev!.Next = curr.Next;
                }
                return true;
            }
            prev = curr;
            curr = curr.Next!;
        } while (curr != head);

        return false;
    }

    public int CountBookedTickets()
    {
        if (head == null) return 0;
        int count = 0;
        TicketNode temp = head;
        do
        {
            count++;
            temp = temp.Next!;
        } while (temp != head);
        return count;
    }

    public void SearchByCustomerOrMovie(string query)
    {
        if (head == null)
        {
            Console.WriteLine("No booked tickets to search.");
            return;
        }
        TicketNode temp = head;
        bool found = false;
        do
        {
            if (temp.CustomerName.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                temp.MovieName.Contains(query, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Matched Reservation: Ticket #{temp.TicketId} | Customer: {temp.CustomerName} | Movie: {temp.MovieName} | Seat: {temp.SeatNumber}");
                found = true;
            }
            temp = temp.Next!;
        } while (temp != head);

        if (!found) Console.WriteLine($"No reservations found matching '{query}'.");
    }

    public void DisplayAllTickets()
    {
        if (head == null)
        {
            Console.WriteLine("No active ticket reservations.");
            return;
        }
        Console.WriteLine("--- Booked Tickets ---");
        TicketNode temp = head;
        do
        {
            Console.WriteLine($"Ticket #{temp.TicketId} | Customer: {temp.CustomerName} | Movie: {temp.MovieName} | Seat: {temp.SeatNumber} | Time: {temp.BookingTime}");
            temp = temp.Next!;
        } while (temp != head);
    }
}

public class OnlineTicketReservationCircularLinkedList
{
    public static void Run()
    {
        Console.WriteLine("--- Circular Linked List: Online Ticket Reservation System ---");

        TicketReservationCircularLinkedList system = new TicketReservationCircularLinkedList();
        system.AddTicket(1001, "Emma Watson", "Oppenheimer", "A12", "18:30");
        system.AddTicket(1002, "Tom Holland", "Spider-Man", "B05", "19:00");
        system.AddTicket(1003, "Zendaya", "Dune: Part Two", "C08", "20:15");

        system.DisplayAllTickets();
        Console.WriteLine($"Total Booked Tickets: {system.CountBookedTickets()}");

        Console.WriteLine("\nSearching reservations for 'Dune'...");
        system.SearchByCustomerOrMovie("Dune");

        Console.WriteLine("\nCancelling Ticket #1002...");
        system.RemoveTicketById(1002);

        Console.WriteLine();
        system.DisplayAllTickets();
    }
}
