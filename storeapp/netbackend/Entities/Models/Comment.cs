using System.ComponentModel.DataAnnotations;

namespace Entities.Models;

public class Comment
{
    public int CommentId { get; set; }

    [Required(ErrorMessage = "Text is required.")]
    public String? Text { get; set; }

    [Required(ErrorMessage = "ProductId is required.")]
    public int ProductId { get; set; }
    public Product? Product { get; set; } // Navigation
    public DateTime AtCreatedDate { get; set; }

    public Comment()
    {
        AtCreatedDate = DateTime.Now;
    }
}