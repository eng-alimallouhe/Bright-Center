using BrightCenter.Domain.Entities.StockManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrightCenter.Infrastructure.Configurations.StockManagement
{
    public class InventoryLogConfigurations :
        IEntityTypeConfiguration<InventoryLog>
    {
        public void Configure(EntityTypeBuilder<InventoryLog> builder)
        {
            builder.HasKey(i => i.InventoryLogId);

            builder.Property(i => i.InventoryLogId)
                    .ValueGeneratedOnAdd();

            builder.Property(i => i.LogDate)
                    .IsRequired();

            builder.Property(i => i.ChangeType)
                    .IsRequired();

            builder.HasOne(i => i.Product)
                    .WithMany(p => p.InventoryLogs)
                    .HasForeignKey(i => i.ProductId)
                    .IsRequired();
        }
    }
}
