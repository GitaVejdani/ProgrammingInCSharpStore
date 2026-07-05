namespace ProgrammingInCSharp___Store.Domain;

public class Product
{
    public int ID { get; set; }
    public int CategoryID { get; set; }
    public string Name { get; set; }
	public  decimal Price { get; set; }

    public int CurrentStock { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
}
