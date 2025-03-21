using BrightCenter.Domain.Entities.UsersManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrightCenter.Infrastructure.Configurations.UsersManagement
{
    public class RoleConfigurations :
        IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(r => r.RoleId);

            builder.Property(r => r.RoleId)
                    .ValueGeneratedOnAdd();

            builder.Property(r => r.RoleType)
                    .IsRequired()
                    .HasMaxLength(50);
            
            builder.Property(r => r.IsActive)
                    .HasDefaultValue(true);

            builder.Property(r => r.CreatedAt)
                    .HasDefaultValueSql("GETDATE()");
            builder.Property(r => r.UpdatedAt)
                    .HasDefaultValueSql("GETDATE()");
        }
    }
}
