using BrightCenter.Domain.Entities.EmployeesManagement;
using BrightCenter.Domain.Entities.UsersManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrightCenter.Infrastructure.Configurations.EmployeesManagement
{
    public class LeaveConfigurations :
        IEntityTypeConfiguration<Leave>
    {
        public void Configure(EntityTypeBuilder<Leave> builder)
        {
            builder.HasKey(l => l.LeaveId);
            
            builder.Property(l => l.LeaveId)
                    .ValueGeneratedOnAdd();
            
            builder.Property(l => l.StartDate)
                    .IsRequired();
            
            builder.Property(l => l.EndDate)
                    .IsRequired();
            
            builder.Property(l => l.LeaveType)
                    .IsRequired();
            
            builder.Property(l => l.IsApproved)
                    .IsRequired();
            
            builder.Property(l => l.IsActive)
                    .HasDefaultValueSql("1");

            builder.Property(l => l.IsPaid)
                    .IsRequired();
            
            builder.HasOne(l => l.Employee)
                .WithMany(e => e.Leaves)
                .HasForeignKey(l => l.EmployeeId)
                .IsRequired();
        }
    }
}
