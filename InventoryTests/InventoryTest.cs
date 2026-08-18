using Inventory;

namespace InventoryTests;
using Inventory;
[TestFixture]
public class InventoryTest
{
    public Stock<Inventory> stock;

    [SetUp]
    public void SetUp()
    {
        stock = new Stock<Inventory>();
    }
    
    [TestCase(5, 10, 50)]
    public void TotalCost(int a, int b, int exp)
    {
        int res = stock.Price(a, b);
        Assert.That(res, Is.EqualTo(exp));
    }

    [Test]
    public void CheckAdd()
    {
        Inventory item =
            new Inventory(101, "Wireless Mouse", 10, 799, "Electronics");

        bool result = stock.AddStock(item);

        Assert.That(result, Is.True);
    }

    [Test]
    public void CheckInvalidName()
    {
        Inventory item =
            new Inventory(102, "Wireless@Mouse", 10, 798, "Electronics");

        bool result = stock.AddStock(item);

        Assert.That(result, Is.False);
    }

    [Test]
    public void CheckDuplicateId()
    {
        Inventory item1 =
            new Inventory(101, "Mouse", 10, 500, "Electronics");

        Inventory item2 =
            new Inventory(101, "Keyboard", 5, 1000, "Electronics");

        stock.AddStock(item1);

        bool result = stock.AddStock(item2);

        Assert.That(result, Is.False);
    }

    [Test]
    public void CheckTotalValue()
    {
        Inventory item =
            new Inventory(103, "Keyboard", 5, 1000, "Electronics");

        decimal result = stock.TotalValue(item);

        Assert.That(result, Is.EqualTo(5000));
    }

   
}