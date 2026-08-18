namespace TicketManagement;

public class Ticket
{
 public int Id { get; set; }
 public string Name { get; set; }
 public string Email { get; set; }
 public string Issue { get; set; }
 public string Status { get; set; }

 public Ticket(int Id, string Name, string Email, string Issue, string Status)
 {
  this.Id = Id;
  this.Name = Name;
  this.Email = Email;
  this.Issue = Issue;
  this.Status = "Open";
 }

}