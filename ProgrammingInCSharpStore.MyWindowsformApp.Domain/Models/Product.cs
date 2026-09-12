using ProgrammingInCSharpStore.MyWindowsformApp.Domain.Contracts;

namespace ProgrammingInCSharpStore.MyWindowsformApp.Domain.Models;

public class Product:IEntity<long>
{
    public long Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
    public short CategoryID { get; set; }
   	public  decimal Price { get; set; }

    public int CurrentStock { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public string PersianName { get; set; }
}
