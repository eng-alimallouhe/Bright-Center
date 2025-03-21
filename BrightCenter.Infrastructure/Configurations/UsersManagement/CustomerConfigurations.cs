using BrightCenter.Domain.Entities.UsersManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrightCenter.Infrastructure.Configurations.UsersManagement
{
    public class CustomerConfigurations :
        IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.CustomerId);

            builder.Property(c => c.CustomerId)
                    .ValueGeneratedOnAdd();

            builder.Property(c => c.Points)
                    .HasColumnType("Decimal(5,2)")
                    .IsRequired();

            builder.HasOne(c => c.User)
                    .WithOne()
                    .HasForeignKey<Customer>(c => c.UserId)
                    .IsRequired();
            
            builder.HasOne(c => c.Level)
                    .WithMany()
                    .HasForeignKey(c => c.LevelId)
                    .IsRequired();
        }
    }
}
