using BrightCenter.Domain.Entities.UsersManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrightCenter.Infrastructure.Configurations.UsersManagement
{
    public class EmployeeConfigurations :
        IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.EmployeeId);

            builder.Property(e => e.EmployeeId)
                    .ValueGeneratedOnAdd();

            builder.Property(e => e.HireDate)
                    .IsRequired();

            builder.Property(e => e.BaseSalary)
                    .HasColumnType("Decimal(5,2)")
                    .IsRequired();

            builder.HasOne(e => e.User)
                    .WithOne()
                    .HasForeignKey<Employee>(e => e.UserId)
                    .IsRequired();
        }
    }
}
