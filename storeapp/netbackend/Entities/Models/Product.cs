using System.ComponentModel.DataAnnotations;

namespace Entities.Models;

public class Product
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required.")]
    public String Name { get; set; } = String.Empty;

    [Range(100, 900, ErrorMessage = "Price must be between 100 and 900.")]
    public Decimal Price { get; set; }

    public String? ImageURL { get; set; }
    public DateTime AtCreatedDate { get; set; }

    public ICollection<Comment>? Comments { get; set; } // Collection navigation property

    public Product()
    {
        AtCreatedDate = DateTime.Now;
        ImageURL = "/images/default.jpg";
    }
}