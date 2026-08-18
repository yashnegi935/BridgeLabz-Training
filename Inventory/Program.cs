namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory mouse = new Inventory(
                1,
                "Wireless Mouse",
                12,
                799,
                "Electronics"
            );

            Stock<Inventory> stock = new Stock<Inventory>();

            bool result = stock.AddStock(mouse);

            Console.WriteLine(result);

            Console.WriteLine("Total Value: " + stock.TotalValue(mouse));
            
            Inventory lowStock = stock.GetLowStock(mouse);

            if (lowStock != null)
            {
                Console.WriteLine("Low Stock: " + lowStock.Name);
            }
            else
            {
                Console.WriteLine("Stock is sufficient");
            }

            
            
        }
        
      }
}