using BrightCenter.Domain.Entities.UsersManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrightCenter.Infrastructure.Configurations.UsersManagement
{
    public class UserConfigurations :
        IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.UserId);

            builder.Property(u => u.UserId)
                    .ValueGeneratedOnAdd();

            builder.Property(u => u.FirstName)
                    .IsRequired()
                    .HasMaxLength(60);

            builder.Property(u => u.LastName)
                    .IsRequired()
                    .HasMaxLength(60);

            builder.Property(u => u.UserName)
                    .IsRequired()
                    .HasMaxLength(60);

            builder.HasIndex(u => u.UserName)
                    .IsUnique();

            builder.Property(u => u.Email)
                    .IsRequired()
                    .HasMaxLength(60);

            builder.HasIndex(u => u.Email)
                    .IsUnique();

            builder.Property(u => u.Password)
                    .IsRequired()
                    .HasMaxLength(60);

            builder.Property(u => u.IsLocked)
                    .HasDefaultValueSql("0");

            builder.Property(u => u.IsDeleted)
                    .HasDefaultValueSql("0");

            builder.Property(u => u.CreatedAt)
                   .HasDefaultValueSql("GETDATE()");
            builder.Property(u => u.UpdatedAt)
                    .HasDefaultValueSql("GETDATE()");

            builder.HasOne(u => u.Role)
                    .WithMany()
                    .HasForeignKey(u => u.RoleId)
                    .IsRequired();
        }
    }
}
