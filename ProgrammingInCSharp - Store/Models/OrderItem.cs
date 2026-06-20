using ProgrammingInCSharp___Store.Enums;

namespace ProgrammingInCSharp___Store.Models;

public class OrderItem
{
    public int ID { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public OrderStatus Status { get; set; }

   

}
