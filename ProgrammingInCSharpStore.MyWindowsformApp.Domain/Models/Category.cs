using ProgrammingInCSharpStore.MyWindowsformApp.Domain.Contracts;

namespace ProgrammingInCSharpStore.MyWindowsformApp.Domain.Models;

public class Category: IEntity<short>
{
    public short Id { get; set; } 
    public DateTime CreatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public short ParentCategoryId { get; set; }
    public string PersianName { get; set; }

}
