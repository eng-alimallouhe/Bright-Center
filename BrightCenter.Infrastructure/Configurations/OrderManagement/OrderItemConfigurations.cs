using BrightCenter.Domain.Entities.OrdersManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrightCenter.Infrastructure.Configurations.OrderManagement
{
    public class OrderItemConfigurations :
        IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasKey(oi => oi.OrderItemId);
            
            builder.Property(oi => oi.OrderItemId)
                    .ValueGeneratedOnAdd();
            
            builder.Property(oi => oi.Quantity)
                    .IsRequired();
            
            builder.Property(oi => oi.UnitPrice)
                    .HasColumnType("decimal(7, 2)");
            
            builder.Property(oi => oi.Discount)
                    .HasColumnType("decimal(7, 2)")
                    .HasDefaultValue(0.0d);
            
            builder.Property(oi => oi.TotalPrice)
                    .HasColumnType("decimal(7, 2)");
            
            builder.Property(oi => oi.IsActive)
                    .HasDefaultValueSql("1");
            
            builder.Property(oi => oi.CreatedAt)
                    .HasDefaultValueSql("GETDATE()");
            
            builder.Property(oi => oi.UpdatedAt)
                    .HasDefaultValueSql("GETDATE()");
            
            builder.HasOne(oi => oi.SellOrder)
                .WithMany(so => so.OrderItems)
                .HasForeignKey(oi => oi.SellOrderId);
            
            builder.HasOne(oi => oi.Product)
                    .WithMany()
                    .HasForeignKey(oi => oi.ProductId);
        }
    }
}
