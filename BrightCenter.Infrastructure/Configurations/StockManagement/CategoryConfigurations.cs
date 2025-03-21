using BrightCenter.Domain.Entities.StockManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrightCenter.Infrastructure.Configurations.StockManagement
{
    public class CategoryConfigurations :
        IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.CategoryId);

            builder.Property(c => c.CategoryId)
                    .ValueGeneratedOnAdd();

            builder.Property(c => c.CategoryName)
                    .IsRequired()
                    .HasMaxLength(60);

            builder.Property(c => c.CategoryDescription)
                    .IsRequired()
                    .HasMaxLength(255);

            builder.Property(c => c.IsActive)
                    .HasDefaultValueSql("1");

            builder.Property(c => c.CreatedAt)
                    .HasDefaultValueSql("GETDATE()");

            builder.Property(c => c.UpdatedAt)
                    .HasDefaultValueSql("GETDATE()");
        }
    }
}
