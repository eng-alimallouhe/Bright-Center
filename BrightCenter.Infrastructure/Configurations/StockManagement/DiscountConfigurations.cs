using BrightCenter.Domain.Entities.StockManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrightCenter.Infrastructure.Configurations.StockManagement
{
    public class DiscountConfigurations :
        IEntityTypeConfiguration<Discount>
    {
        public void Configure(EntityTypeBuilder<Discount> builder)
        {
            builder.HasKey(d => d.DiscountId);
            
            builder.Property(d => d.DiscountId)
                    .ValueGeneratedOnAdd();
            
            builder.Property(d => d.DiscountPercentage)
                    .HasColumnType("Decimal(5,2)")
                    .IsRequired();
            
            builder.Property(d => d.StartDate)
                    .IsRequired();
            
            builder.Property(d => d.EndDate)
                    .IsRequired();
            
            builder.Property(d => d.IsActive)
                    .HasDefaultValue(true);
            
            builder.Property(d => d.CreatedAt)
                    .HasDefaultValueSql("GETDATE()");
            
            builder.Property(d => d.UpdatedAt)
                    .HasDefaultValueSql("GETDATE()");
            
            builder.HasOne(d => d.Product)
                    .WithMany(p => p.Discounts)
                    .HasForeignKey(d => d.ProductId)
                    .IsRequired();
        }
    }
}
