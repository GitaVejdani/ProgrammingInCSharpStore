

using ProgrammingInCSharp___Store.Domain.Enums;

namespace ProgrammingInCSharp___Store.Domain.Models;

public class Cart
{
    public int ID { get; set; }
    public int CustomerID { get; set; }
    public CartStatus Type { get; set; } 
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
   
	


}
