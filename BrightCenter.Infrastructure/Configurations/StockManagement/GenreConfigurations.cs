using BrightCenter.Domain.Entities.StockManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrightCenter.Infrastructure.Configurations.StockManagement
{
    public class GenreConfigurations :
        IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasKey(g => g.GenreId);

            builder.Property(g => g.GenreId)
                    .ValueGeneratedOnAdd();
            
            builder.Property(g => g.GenreName)
                    .IsRequired()
                    .HasMaxLength(60);

            builder.Property(g => g.GenreDescription)
                    .IsRequired()
                    .HasMaxLength(255);

            builder.Property(g => g.IsActive)
                    .HasDefaultValueSql("1");
            
            builder.Property(g => g.CreatedAt)
                    .HasDefaultValueSql("GETDATE()");
            
            builder.Property(g => g.UpdatedAt)
                    .HasDefaultValueSql("GETDATE()");
        }
    }
}
