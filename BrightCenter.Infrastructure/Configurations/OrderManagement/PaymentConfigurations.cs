using BrightCenter.Domain.Entities.OrdersManagement;
using BrightCenter.Domain.Entities.UsersManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrightCenter.Infrastructure.Configurations.OrderManagement
{
    public class PaymentConfigurations :
        IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasKey(p => p.PaymentId);

            builder.Property(p => p.PaymentId)
                    .ValueGeneratedOnAdd();

            builder.Property(p => p.Date)
                    .IsRequired();

            builder.Property(p => p.Amount)
                    .HasColumnType("decimal(7, 2)");

            builder.Property(p => p.PaymentMethod)
                    .IsRequired();

            builder.Property(p => p.PaymentStatus)
                    .IsRequired();

            builder.Property(p => p.IsActive)
                    .HasDefaultValueSql("1");

            builder.Property(p => p.CreatedAt)
                    .HasDefaultValueSql("GETDATE()");

            builder.Property(p => p.UpdatedAt)
                    .HasDefaultValueSql("GETDATE()");

            builder.HasOne(p => p.Customer)
                    .WithMany(c => c.Payments)
                    .HasForeignKey(p => p.CustomerId)
                    .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Employee)
                    .WithMany(e => e.Payments)
                    .HasForeignKey(p => p.EmployeeId)
                    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
