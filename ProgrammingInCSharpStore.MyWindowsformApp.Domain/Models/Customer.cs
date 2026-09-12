using ProgrammingInCSharpStore.MyWindowsformApp.Domain.Contracts;

namespace ProgrammingInCSharpStore.MyWindowsformApp.Domain.Models;

public class Customer: IEntity<long>
{
    public long Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalCode { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
	
}
