using ProgrammingInCSharp___Store.Enums;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProgrammingInCSharp___Store.Models;

public class Cart
{
    public int ID { get; set; }
    public int CustomerID { get; set; }
    public CartStatus Type { get; set; } 
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
   
	


}
