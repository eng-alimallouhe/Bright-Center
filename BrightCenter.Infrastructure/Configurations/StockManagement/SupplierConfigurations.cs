using BrightCenter.Domain.Entities.StockManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrightCenter.Infrastructure.Configurations.StockManagement
{
    public class SupplierConfigurations :
        IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasKey(s => s.SupplierId);

            builder.Property(s => s.SupplierId)
                    .ValueGeneratedOnAdd();

            builder.Property(s => s.SupplierName)
                    .IsRequired()
                    .HasMaxLength(60);

            builder.Property(s => s.ContactEmail)
                    .IsRequired()
                    .HasMaxLength(255);

            builder.Property(s => s.ContactPhone)
                    .IsRequired()
                    .HasMaxLength(20);

            builder.Property(s => s.IsActive)
                    .HasDefaultValueSql("1");

            builder.Property(p => p.CreatedAt)
                    .HasDefaultValueSql("GETDATE()");

            builder.Property(p => p.UpdatedAt)
                    .HasDefaultValueSql("GETDATE()");
        }
    }
}
