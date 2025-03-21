using BrightCenter.Domain.Entities.OrdersManagement;
using BrightCenter.Domain.Entities.UsersManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrightCenter.Infrastructure.Configurations.OrderManagement
{
    public class SellOrderConfigurations :
        IEntityTypeConfiguration<SellOrder>
    {
        public void Configure(EntityTypeBuilder<SellOrder> builder)
        {
            builder.HasKey(so => so.SellOrderId);

            builder.Property(so => so.SellOrderId)
                    .ValueGeneratedOnAdd();

            builder.Property(so => so.OrderCost)
                    .HasColumnType("decimal(7, 2)");

            builder.Property(so => so.DeliveryCost)
                    .HasColumnType("decimal(7, 2)")
                    .HasDefaultValue(0.0d);

            builder.Property(so => so.TotalCost)
                    .HasColumnType("decimal(7, 2)");

            builder.Property(so => so.Date)
                    .IsRequired();

            builder.Property(so => so.DeliveryMethod)
                    .IsRequired();

            builder.Property(so => so.PaymentMethod)
                    .IsRequired();

            builder.Property(so => so.PaymentStatus)
                    .IsRequired();

            builder.Property(so => so.IsActive)
                    .HasDefaultValue(true);

            builder.Property(so => so.CreatedAt)
                    .HasDefaultValueSql("GETDATE()");

            builder.Property(so => so.UpdatedAt)
                    .HasDefaultValueSql("GETDATE()");

            builder.HasOne(so => so.Customer)
                .WithMany(c => c.SellOrders)
                .HasForeignKey(so => so.CustomerId);

            builder.HasOne(so => so.Employee)
                .WithMany(e => e.SellOrders)
                .HasForeignKey(so => so.EmployeeId);
        }

    }
}
