using BrightCenter.Domain.Entities.StockManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrightCenter.Infrastructure.Configurations.StockManagement
{
    public class PublisherConfigurations :
        IEntityTypeConfiguration<Publisher>
    {
  
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.HasKey(p => p.PublisherId);
            
            builder.Property(p => p.PublisherId)
                    .ValueGeneratedOnAdd();

            builder.Property(p => p.PublisherName)
                    .IsRequired()
                    .HasMaxLength(60);

            builder.Property(p => p.PublisherDescription)
                    .IsRequired()
                    .HasMaxLength(255);

            builder.Property(p => p.IsActive)
                    .HasDefaultValue(true);

            builder.Property(p => p.CreatedAt)
                    .HasDefaultValueSql("GETDATE()");

            builder.Property(p => p.UpdatedAt)
                    .HasDefaultValueSql("GETDATE()");

            builder.HasMany(p => p.Books)
                    .WithMany(b => b.Publishers)
                    .UsingEntity(j => j.ToTable("BookPublisher"));
        }
    }
}
