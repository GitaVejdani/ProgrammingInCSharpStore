using ProgrammingInCSharp___Store.Domain;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProgrammingInCSharp___Store.Domain;

public class Cart
{
    public int ID { get; set; }
    public int CustomerID { get; set; }
    public CartStatus Type { get; set; } 
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
   
	


}
