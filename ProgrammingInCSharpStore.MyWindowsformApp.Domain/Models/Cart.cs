
using ProgrammingInCSharpStore.MyWindowsformApp.Domain.Contracts;
using ProgrammingInCSharpStore.MyWindowsformApp.Domain.Enums;


namespace ProgrammingInCSharpStore.MyWindowsformApp.Domain.Models;

public class Cart:IEntity<long>
{
    public long Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
    public CartStatus Status { get; set; }
    public long CustomerID { get; set; }
    public DateTime? UpdatedAt { get; set; }
    
    public List<CartItem> Items { get; set; } = new();


    public void AddItem(Product product, int quantity)
    {
        // ...
    }

    public void RemoveItem(int productId)
    {
        // ...
    }

    public void UpdateQuantity(int productId, int quantity)
    {
        // ...
    }

    //public decimal TotalPrice() {}
    // public Customer Customer { get; set; }
    // public void AddItem(Product product, int quantity) { }
   // public void RemoveItem(int productId) { }









}
