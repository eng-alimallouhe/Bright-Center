using BrightCenter.Domain.Entities.StockManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrightCenter.Infrastructure.Configurations.StockManagement
{
    public class PurchaseConfigurations :
        IEntityTypeConfiguration<Purchase>
    {
        public void Configure(EntityTypeBuilder<Purchase> builder)
        {
            builder.HasKey(p => p.PurchaseId);
           
            builder.Property(p => p.PurchaseId)
                    .ValueGeneratedOnAdd();
            
            builder.Property(p => p.PurchaseDate)
                    .IsRequired();
            
            builder.Property(p => p.TotalAmount)
                    .HasColumnType("Decimal(7,2)")
                    .IsRequired();
            
            builder.Property(p => p.CurrencyCode)
                    .HasMaxLength(3);
            
            builder.Property(p => p.Notes)
                    .HasMaxLength(255);
            
            builder.Property(p => p.IsActive)
                    .HasDefaultValueSql("1");
            
            builder.Property(p => p.CreatedAt)
                    .HasDefaultValueSql("GETDATE()");
            
            builder.Property(p => p.UpdatedAt)
                    .HasDefaultValueSql("GETDATE()");
            
            builder.HasOne(p => p.Supplier)
                    .WithMany(s => s.Purchases)
                    .HasForeignKey(p => p.SupplierId)
                    .IsRequired();
        }
    }
}
