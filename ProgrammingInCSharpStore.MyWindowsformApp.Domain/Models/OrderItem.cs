using ProgrammingInCSharp___Store.Domain.Enums;

namespace ProgrammingInCSharp___Store.Domain.Models;

public class OrderItem
{
    public int ID { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public OrderStatus Status { get; set; }

   

}
