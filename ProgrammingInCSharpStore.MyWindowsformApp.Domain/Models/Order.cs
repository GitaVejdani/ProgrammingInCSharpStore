using ProgrammingInCSharpStore.MyWindowsformApp.Domain.Contracts;
using ProgrammingInCSharpStore.MyWindowsformApp.Domain.Enums;

namespace ProgrammingInCSharpStore.MyWindowsformApp.Domain.Models;

public class Order:IEntity<long>

{
    public long Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
    public OrderStatus Status { get; set; }

    public long CustomerId { get; set; }
    public long CartId { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }



}
