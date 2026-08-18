using System.Text.RegularExpressions;

namespace TicketManagement;

public class TicketManager
{
    public Dictionary<int, Ticket> tickets = new Dictionary<int, Ticket>();

    public bool AddTickets(Ticket ticket)
    {
        if (tickets.ContainsKey(ticket.Id)) return false;
        
        string pattern=@"^[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-zA-Z]+$";
        if (!Regex.IsMatch(ticket.Email, pattern)) return false;
        
        tickets.Add(ticket.Id,ticket);
        return true;
    }

    public String GetTicket(int id)
    {
        if (tickets.TryGetValue(id, out Ticket ticket))
        {
            return ticket.Name;
        }
        return null;
    }
    
    public bool UpdateStatus(int id, string status)
    {
        if (!tickets.ContainsKey(id))
        {
            return false;
        }

        tickets[id].Status = status;

        return true;
    }

    public void Displayticket()
    {
        foreach (var tickets in tickets.Values)
        {
            Console.WriteLine(tickets.Id + " "+ tickets.Email+" "+tickets.Name+" "+tickets.Status);
        }
    }
    public int Count()
    {
        return tickets.Count;
    }

}