using BrightCenter.Domain.Entities.UsersManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrightCenter.Infrastructure.Configurations.UsersManagement
{
    public class LevelConfigurations :
        IEntityTypeConfiguration<Level>
    {
        public void Configure(EntityTypeBuilder<Level> builder)
        {
            builder.HasKey(l => l.LevelId);

            builder.Property(l => l.LevelId)
                    .ValueGeneratedOnAdd();

            builder.Property(l => l.LevelName)
                    .IsRequired()
                    .HasMaxLength(60);
            
            builder.Property(l => l.RequiredPoints)
                    .IsRequired();
            
            builder.Property(l => l.DiscountPercentage)
                    .HasColumnType("Decimal(5,2)")
                    .IsRequired();
            
            builder.Property(l => l.IsActive)
                    .HasDefaultValueSql("1");

            builder.Property(l => l.LevelDescription)
                    .IsRequired()
                    .HasMaxLength(255);
            
            builder.Property(l => l.CreatedAt)
                    .HasDefaultValueSql("GETDATE()");
            
            builder.Property(l => l.UpdatedAt)
                    .HasDefaultValueSql("GETDATE()");
        }
    }
}
