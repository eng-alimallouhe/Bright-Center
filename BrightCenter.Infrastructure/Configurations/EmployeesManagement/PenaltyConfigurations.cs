using BrightCenter.Domain.Entities.EmployeesManagement;
using BrightCenter.Domain.Entities.UsersManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrightCenter.Infrastructure.Configurations.EmployeesManagement
{
    public class PenaltyConfigurations :
        IEntityTypeConfiguration<Penalty>
    {
      public void Configure(EntityTypeBuilder<Penalty> builder)
        {
            builder.HasKey(p => p.PenaltyId);
            
            builder.Property(p => p.PenaltyId)
                    .ValueGeneratedOnAdd();
            
            builder.Property(p => p.Amount)
                    .HasColumnType("decimal(5,2)")
                    .IsRequired();
            
            builder.Property(p => p.Reason)
                    .IsRequired()
                    .HasMaxLength(100);

            builder.Property(p => p.Date)
                    .IsRequired();
            
            builder.Property(p => p.IsActive)
                    .HasDefaultValueSql("1");


            builder.HasOne(p => p.Employee)
                .WithMany(e => e.Penalties)
                .HasForeignKey(p => p.EmployeeId)
                .IsRequired();
        }
    }
}
