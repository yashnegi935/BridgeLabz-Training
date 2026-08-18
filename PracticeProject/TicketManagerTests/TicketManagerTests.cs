using TicketManagement;

namespace TicketManagerTests;

[TestFixture]
public class TicketManagerTests
{
    public TicketManager manager;

    [SetUp]
    public void SetUp()
    {
        manager = new TicketManager();
    }

    [Test]
    public void CheckAddTicket()
    {
        Ticket ticket = new Ticket(
 101,"Yash","Yashnegi935@gmail.com","Technical Issue","Waiting"           
            );
        bool result = manager.AddTickets(ticket);
        Assert.That(result,Is.True);
        
    }

    [Test]
    public void CheckEmail()
    {
        Ticket ticket = new Ticket(
            101,"Yash","Yashnegi93gmail.com","Technical Issue","Waiting"           
        );
        bool result = manager.AddTickets(ticket);
        Assert.That(result,Is.False);

    }

    [Test]
    public void CheckId()
    {
        Ticket ticket = new Ticket(
            101,"Yash","Yashnegi93@gmail.com","Technical Issue","Waiting"           
        );
        manager.AddTickets(ticket);
        string result = manager.GetTicket(101);
        
        Assert.That(result,Is.EqualTo("Yash"));

    }
    

}