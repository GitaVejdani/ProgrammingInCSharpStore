using ProgrammingInCSharpStore.MyWindowsformApp.Domain.Contracts;
using ProgrammingInCSharpStore.MyWindowsformApp.Domain.Enums;

namespace ProgrammingInCSharpStore.MyWindowsformApp.Domain.Models;

public class Order:IEntity<long>

{
    public long Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public OrderStatus Status { get; set; }


}
