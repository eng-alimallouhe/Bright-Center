using BrightCenter.Domain.Entities.StockManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrightCenter.Infrastructure.Configurations.StockManagement
{
    public class ProductConfigurations :
        IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);

            builder.Property(p => p.ProductId)
                    .ValueGeneratedOnAdd();

            builder.Property(p => p.ProductName)
                    .IsRequired()
                    .HasMaxLength(60);

            builder.Property(p => p.ProductDescription)
                    .IsRequired()
                    .HasMaxLength(255);

            builder.Property(p => p.ProductPrice)
                    .HasColumnType("Decimal(7,2)")
                    .IsRequired();

            builder.Property(p => p.ProductStock)
                    .IsRequired();

            builder.Property(p => p.IsActive)
                    .HasDefaultValueSql("1");

            builder.Property(p => p.CreatedAt)
                    .HasDefaultValueSql("GETDATE()");

            builder.Property(p => p.UpdatedAt)
                    .HasDefaultValueSql("GETDATE()");

            builder.HasOne(p => p.Category)
                    .WithMany(c => c.Products)
                    .HasForeignKey(p => p.CategoryId)
                    .IsRequired();

        }
    }
}
