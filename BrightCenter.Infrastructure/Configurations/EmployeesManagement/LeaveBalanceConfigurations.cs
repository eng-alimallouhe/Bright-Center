using BrightCenter.Domain.Entities.EmployeesManagement;
using BrightCenter.Domain.Entities.UsersManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrightCenter.Infrastructure.Configurations.EmployeesManagement
{
    public class LeaveBalanceConfigurations :
        IEntityTypeConfiguration<LeaveBalance>
    {
        public void Configure(EntityTypeBuilder<LeaveBalance> builder)
        {
            builder.HasKey(lb => lb.LeaveBalanceId);

            builder.Property(lb => lb.LeaveBalanceId)
                    .ValueGeneratedOnAdd();

            builder.Property(lb => lb.RemainBalance)
                    .IsRequired();

            builder.Property(lb => lb.TotalBalance)
                    .IsRequired();

            builder.Property(builder => builder.BaseBalance)
                    .IsRequired();

            builder.Property(lb => lb.RoundedBalance)
                    .IsRequired();

            builder.Property(lb => lb.Year)
                    .IsRequired();

            builder.HasOne(lb => lb.Employee)
                .WithMany(e => e.LeaveBalances)
                .HasForeignKey(lb => lb.EmployeeId)
                .IsRequired();
        }
    }
}
