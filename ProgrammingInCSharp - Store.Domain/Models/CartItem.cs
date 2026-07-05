using ProgrammingInCSharp___Store.Domain;

namespace ProgrammingInCSharp___Store.Domain;

public class CartItem
{
    public int ID { get; set; }
    public int CartId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice  { get; set; }
   


}
