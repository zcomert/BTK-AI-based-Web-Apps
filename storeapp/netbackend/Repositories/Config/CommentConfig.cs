using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config;

public class CommentConfig : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder
            .ToTable("Comments");

        builder
            .HasKey(c => c.CommentId);

        builder
            .Property(c => c.Text).IsRequired();

        builder.HasData(
            new Comment() { CommentId = 1, ProductId = 1, Text = "Harika bir ürün." },
            new Comment() { CommentId = 2, ProductId = 1, Text = "Harika bir ürün, kesinlikle tavsiye ediyorum." },
            new Comment() { CommentId = 3, ProductId = 1, Text = "Kargo biraz gecikti ama beklediğime değdi. Teşekkürler" }
        );
    }
}