namespace Entities.Models;

public class Product
{
    public int Id { get; set; }
    public String Name { get; set; } = String.Empty;
    public Decimal Price { get; set; }
    public DateTime AtCreatedDate { get; set; }

    public Product()
    {
        AtCreatedDate = DateTime.Now;
    }
}