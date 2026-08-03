namespace CalculatorProblems;

public class MultiOrder
{
    public int OrderId { get; set; }
    public string OrderDate { get; set; }

    public MultiOrder(int orderId, string orderDate)
    {
        OrderId = orderId;
        OrderDate = orderDate;
    }

    public virtual string GetOrderStatus()
    {
        return $"Order #{OrderId} placed on {OrderDate}.";
    }
}

public class MultiShippedOrder : MultiOrder
{
    public string TrackingNumber { get; set; }

    public MultiShippedOrder(int orderId, string orderDate, string trackingNumber)
        : base(orderId, orderDate)
    {
        TrackingNumber = trackingNumber;
    }

    public override string GetOrderStatus()
    {
        return $"{base.GetOrderStatus()} Shipped with Tracking #{TrackingNumber}.";
    }
}

public class MultiDeliveredOrder : MultiShippedOrder
{
    public string DeliveryDate { get; set; }

    public MultiDeliveredOrder(int orderId, string orderDate, string trackingNumber, string deliveryDate)
        : base(orderId, orderDate, trackingNumber)
    {
        DeliveryDate = deliveryDate;
    }

    public override string GetOrderStatus()
    {
        return $"{base.GetOrderStatus()} Delivered on {DeliveryDate}.";
    }
}

public class OrderMultilevelInheritance
{
    public static void Run()
    {
        Console.WriteLine("--- Multilevel Inheritance: Online Retail Order ---");

        MultiOrder order = new MultiOrder(101, "2026-08-01");
        MultiShippedOrder shipped = new MultiShippedOrder(102, "2026-08-01", "TRK987654");
        MultiDeliveredOrder delivered = new MultiDeliveredOrder(103, "2026-08-01", "TRK123456", "2026-08-03");

        Console.WriteLine(order.GetOrderStatus());
        Console.WriteLine(shipped.GetOrderStatus());
        Console.WriteLine(delivered.GetOrderStatus());
    }
}
