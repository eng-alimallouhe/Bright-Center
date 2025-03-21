using BrightCenter.Domain.Entities.UsersManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrightCenter.Infrastructure.Configurations.UsersManagement
{
    public class DepartmentConfigurations :
        IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(d => d.DepartmentId);
            
            builder.Property(d => d.DepartmentId)
                    .ValueGeneratedOnAdd();

            builder.Property(d => d.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(60);
            
            builder.Property(d => d.Description)
                    .IsRequired()
                    .HasMaxLength(255);
            
            builder.Property(d => d.IsActive)
                    .HasDefaultValueSql("1");
            
            builder.Property(d => d.CreatedAt)
                    .HasDefaultValueSql("GETDATE()");
            
            builder.Property(d => d.UpdatedAt)
                    .HasDefaultValueSql("GETDATE()");
        }
    }
}
