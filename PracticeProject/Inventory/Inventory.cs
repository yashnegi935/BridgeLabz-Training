namespace Inventory;

public class Inventory
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public int Price { get; set; }
    public string Category { get; set; }

    public Inventory(int Id, string Name, int Quantity, int Price, string Category)
    {
        this.Id = Id;
        this.Name = Name;
        this.Quantity = Quantity;
        this.Price = Price;
        this.Category = Category;
    }

    public Inventory()
    {
        
    }

}