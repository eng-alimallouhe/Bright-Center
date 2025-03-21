using BrightCenter.Domain.Entities.EmployeesManagement;
using BrightCenter.Domain.Entities.UsersManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrightCenter.Infrastructure.Configurations.EmployeesManagement
{
    public class SalaryConfigurations :
        IEntityTypeConfiguration<Salary>
    {
        public void Configure(EntityTypeBuilder<Salary> builder)
        {
            builder.HasKey(s => s.SalaryId);

            builder.Property(s => s.SalaryId)
                    .ValueGeneratedOnAdd();

            builder.Property(s => s.Month)
                    .IsRequired();

            builder.Property(s => s.Value)
                    .HasColumnType("decimal(7,2)")
                    .IsRequired();

            builder.Property(s => s.Year)
                    .IsRequired();

            builder.Property(s => s.IsActive)
                    .HasDefaultValueSql("1");

            builder.HasOne(s => s.Employee)
                .WithMany(e => e.Salaries)
                .HasForeignKey(s => s.EmployeeId)
                .IsRequired();
        }
    }
}
