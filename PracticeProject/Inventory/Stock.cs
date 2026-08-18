using System.Text.RegularExpressions;

namespace Inventory;

public class Stock<T> where T : Inventory
{
    public List<T> list = new List<T>();

    public int ReorderLevel = 5;

    public bool AddStock(T inventory)
    {
        string namePattern = @"^[a-zA-Z\s]+$";

        if (!Regex.IsMatch(inventory.Name, namePattern))
        {
            return false;
        }
        
        string quantityPattern = @"^[0-9]+$";

        if (!Regex.IsMatch(inventory.Quantity.ToString(), quantityPattern))
        {
            return false;
        }

        string pricePattern = @"^[0-9]+$";

        if (!Regex.IsMatch(inventory.Price.ToString(), pricePattern))
        {
            return false;
        }

        if (list.Any(item => item.Id == inventory.Id))
        {
            return false;
        }


        list.Add(inventory);

        return true;
    }

    public int Price(int price, int quantity)
    {
        return price * quantity;
    }
    
    
    
    
    

    public decimal TotalValue(T inventory)
    {
        return inventory.Price * inventory.Quantity;
    }

    public T GetLowStock(T item)
    {
        if (item.Quantity < ReorderLevel)
        {
            return item;
        }

        return null;
    }
}