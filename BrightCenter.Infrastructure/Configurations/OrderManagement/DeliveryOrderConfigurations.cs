using BrightCenter.Domain.Entities.OrdersManagement;
using BrightCenter.Domain.Entities.UsersManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrightCenter.Infrastructure.Configurations.OrderManagement
{
    public class DeliveryOrderConfigurations :
        IEntityTypeConfiguration<DeliveryOrder>
    {
        public void Configure(EntityTypeBuilder<DeliveryOrder> builder)
        {
            builder.HasKey(dor => dor.DeliveryOrderId);
            
            builder.Property(dor => dor.DeliveryOrderId)
                    .ValueGeneratedOnAdd();
            
            builder.Property(dor => dor.OrderName)
                    .IsRequired();
            
            builder.Property(dor => dor.Department)
                    .IsRequired();
            
            builder.Property(dor => dor.IsActive)
                    .HasDefaultValueSql("1");
            
            builder.Property(dor => dor.CreatedAt)
                    .HasDefaultValueSql("GETDATE()");
            
            builder.Property(dor => dor.UpdatedAt)
                    .HasDefaultValueSql("GETDATE()");
            
            builder.HasOne(dor => dor.Customer)
                    .WithMany(c => c.DeliveryOrders)
                    .HasForeignKey(dor => dor.CustomerId);
            
            builder.HasOne(dor => dor.Employee)
                    .WithMany(e => e.DeliveryOrders)
                    .HasForeignKey(dor => dor.EmployeeId)
                    .OnDelete(DeleteBehavior.Restrict);
            
            builder.HasOne(dor => dor.Address)
                    .WithOne()
                    .HasForeignKey<DeliveryOrder>(dor => dor.AddressId)
                    .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
