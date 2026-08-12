namespace CalculatorProblems;

public class InventoryItemNode
{
    public int ItemId { get; set; }
    public string ItemName { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
    public InventoryItemNode? Next { get; set; }

    public InventoryItemNode(int itemId, string itemName, int quantity, double price)
    {
        ItemId = itemId;
        ItemName = itemName;
        Quantity = quantity;
        Price = price;
        Next = null;
    }
}

public class InventorySinglyLinkedList
{
    private InventoryItemNode? head;

    public void AddAtBeginning(int id, string name, int quantity, double price)
    {
        InventoryItemNode newNode = new InventoryItemNode(id, name, quantity, price);
        newNode.Next = head;
        head = newNode;
    }

    public void AddAtEnd(int id, string name, int quantity, double price)
    {
        InventoryItemNode newNode = new InventoryItemNode(id, name, quantity, price);
        if (head == null)
        {
            head = newNode;
            return;
        }
        InventoryItemNode temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = newNode;
    }

    public bool RemoveById(int id)
    {
        if (head == null) return false;
        if (head.ItemId == id)
        {
            head = head.Next;
            return true;
        }
        InventoryItemNode temp = head;
        while (temp.Next != null && temp.Next.ItemId != id)
        {
            temp = temp.Next;
        }
        if (temp.Next == null) return false;
        temp.Next = temp.Next.Next;
        return true;
    }

    public bool UpdateQuantity(int id, int newQuantity)
    {
        InventoryItemNode? item = SearchById(id);
        if (item != null)
        {
            item.Quantity = newQuantity;
            return true;
        }
        return false;
    }

    public InventoryItemNode? SearchById(int id)
    {
        InventoryItemNode? temp = head;
        while (temp != null)
        {
            if (temp.ItemId == id) return temp;
            temp = temp.Next;
        }
        return null;
    }

    public void SearchByName(string name)
    {
        InventoryItemNode? temp = head;
        bool found = false;
        while (temp != null)
        {
            if (temp.ItemName.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Found Item: [{temp.ItemId}] {temp.ItemName}, Qty: {temp.Quantity}, Price: {temp.Price:C}");
                found = true;
            }
            temp = temp.Next;
        }
        if (!found) Console.WriteLine($"Item with name '{name}' not found.");
    }

    public double CalculateTotalValue()
    {
        double total = 0;
        InventoryItemNode? temp = head;
        while (temp != null)
        {
            total += temp.Price * temp.Quantity;
            temp = temp.Next;
        }
        return total;
    }

    public void SortByPrice(bool ascending = true)
    {
        if (head == null || head.Next == null) return;
        for (InventoryItemNode? i = head; i != null; i = i.Next)
        {
            for (InventoryItemNode? j = i.Next; j != null; j = j.Next)
            {
                if ((ascending && i.Price > j.Price) || (!ascending && i.Price < j.Price))
                {
                    int tempId = i.ItemId;
                    string tempName = i.ItemName;
                    int tempQty = i.Quantity;
                    double tempPrice = i.Price;

                    i.ItemId = j.ItemId;
                    i.ItemName = j.ItemName;
                    i.Quantity = j.Quantity;
                    i.Price = j.Price;

                    j.ItemId = tempId;
                    j.ItemName = tempName;
                    j.Quantity = tempQty;
                    j.Price = tempPrice;
                }
            }
        }
    }

    public void DisplayAll()
    {
        if (head == null)
        {
            Console.WriteLine("Inventory is empty.");
            return;
        }
        InventoryItemNode? temp = head;
        while (temp != null)
        {
            Console.WriteLine($"ID: {temp.ItemId}, Name: {temp.ItemName}, Quantity: {temp.Quantity}, Unit Price: {temp.Price:C}, Total: {(temp.Price * temp.Quantity):C}");
            temp = temp.Next;
        }
    }
}

public class InventoryManagementLinkedList
{
    public static void Run()
    {
        Console.WriteLine("--- Singly Linked List: Inventory Management ---");

        InventorySinglyLinkedList inventory = new InventorySinglyLinkedList();
        inventory.AddAtBeginning(101, "Monitor", 5, 200.0);
        inventory.AddAtEnd(102, "Keyboard", 15, 45.0);
        inventory.AddAtEnd(103, "Mouse", 25, 20.0);

        inventory.DisplayAll();
        Console.WriteLine($"Total Inventory Value: {inventory.CalculateTotalValue():C}");

        Console.WriteLine("\nSorting inventory by Price (Ascending)...");
        inventory.SortByPrice(true);
        inventory.DisplayAll();
    }
}
