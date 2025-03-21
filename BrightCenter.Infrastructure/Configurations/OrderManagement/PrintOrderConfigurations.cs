using BrightCenter.Domain.Entities.OrdersManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrightCenter.Infrastructure.Configurations.OrderManagement
{
    public class PrintOrderConfigurations :
        IEntityTypeConfiguration<PrintOrder>
    {
        public void Configure(EntityTypeBuilder<PrintOrder> builder)
        {
            builder.HasKey(po => po.PrintOrderId);
            
            builder.Property(po => po.PrintOrderId)
                    .ValueGeneratedOnAdd();
            
            builder.Property(po => po.StartPage)
                    .IsRequired();
            
            builder.Property(po => po.EndPage)
                    .IsRequired();
            
            builder.Property(po => po.CopiesCount)
                    .IsRequired();
            
            builder.Property(po => po.CopyCost)
                    .HasColumnType("decimal(7, 2)");
            
            builder.Property(po => po.TotalCost)
                    .HasColumnType("decimal(7, 2)");
            
            builder.Property(po => po.OrderStatus)
                    .IsRequired();
            
            builder.Property(po => po.FileUrl)
                    .IsRequired();
            
            builder.Property(po => po.FileName)
                    .IsRequired();
            
            builder.Property(po => po.IsActive)
                    .HasDefaultValueSql("1");
            
            builder.Property(po => po.CreatedAt)
                    .HasDefaultValueSql("GETDATE()");
            
            builder.Property(po => po.UpdatedAt)
                    .HasDefaultValueSql("GETDATE()");
            
            builder.HasOne(po => po.Customer)
                    .WithMany(c => c.PrintOrders)
                    .HasForeignKey(po => po.CustomerId)
                    .OnDelete(DeleteBehavior.Restrict);
            
            builder.HasOne(po => po.Employee)
                    .WithMany(e => e.PrintOrders)
                    .HasForeignKey(po => po.EmployeeId)
                    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
