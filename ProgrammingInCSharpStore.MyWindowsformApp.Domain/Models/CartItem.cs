using ProgrammingInCSharpStore.MyWindowsformApp.Domain.Contracts;

namespace ProgrammingInCSharpStore.MyWindowsformApp.Domain.Models;

public class CartItem :IEntity<long>
{
    public long Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
    public long CartId { get; set; }
    public long ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice  { get; set; }




   

}
