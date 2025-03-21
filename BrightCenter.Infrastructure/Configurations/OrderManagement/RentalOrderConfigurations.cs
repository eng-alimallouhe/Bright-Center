using BrightCenter.Domain.Entities.OrdersManagement;
using BrightCenter.Domain.Entities.UsersManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrightCenter.Infrastructure.Configurations.OrderManagement
{
    public class RentalOrderConfigurations :
        IEntityTypeConfiguration<RentalOrder>
    {
        public void Configure(EntityTypeBuilder<RentalOrder> builder)
        {
            builder.HasKey(ro => ro.RentalOrderId);

            builder.Property(ro => ro.RentalOrderId)
                    .ValueGeneratedOnAdd();

            builder.Property(ro => ro.StartDate)
                    .IsRequired();

            builder.Property(ro => ro.EndDate)
                    .IsRequired();

            builder.Property(ro => ro.InitialCost)
                    .HasColumnType("decimal(7, 2)");

            builder.Property(ro => ro.LateCost)
                    .HasColumnType("decimal(7, 2)");

            builder.Property(ro => ro.TotalCost)
                    .HasColumnType("decimal(7, 2)");

            builder.Property(ro => ro.DeliveryMethod)
                    .IsRequired();

            builder.Property(ro => ro.PaymentMethod)
                    .IsRequired();

            builder.Property(ro => ro.PaymentStatus)
                    .IsRequired();

            builder.Property(ro => ro.RentalStatus)
                    .IsRequired();

            builder.Property(ro => ro.IsActive)
                    .HasDefaultValueSql("1");

            builder.Property(ro => ro.CreatedAt)
                    .HasDefaultValueSql("GETDATE()");

            builder.Property(ro => ro.UpdatedAt)
                    .HasDefaultValueSql("GETDATE()");

            builder.HasOne(ro => ro.Customer)
                    .WithMany(c => c.RentalOrders)
                    .HasForeignKey(ro => ro.CustomerId)
                    .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(ro => ro.Employee)
                    .WithMany(e => e.RentalOrders)
                    .HasForeignKey(ro => ro.EmployeeId)
                    .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(ro => ro.Book)
                    .WithMany()
                    .HasForeignKey(ro => ro.BookId)
                    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
