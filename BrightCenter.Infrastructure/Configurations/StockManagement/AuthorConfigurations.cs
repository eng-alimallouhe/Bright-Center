using BrightCenter.Domain.Entities.EmployeesManagement;
using BrightCenter.Domain.Entities.StockManagement;
using BrightCenter.Domain.Entities.UsersManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrightCenter.Infrastructure.Configurations.StockManagement
{
    public class AuthorConfigurations :
        IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(a => a.AuthorId);

            builder.Property(a => a.AuthorId)
                    .ValueGeneratedOnAdd();
           
            builder.Property(a => a.AuthorName)
                    .IsRequired()
                    .HasMaxLength(60);
            
            builder.Property(a => a.AuthorDescription)
                    .IsRequired()
                    .HasMaxLength(255);
            
            builder.Property(a => a.IsActive)
                    .HasDefaultValue(true);
            
            builder.Property(a => a.CreatedAt)
                    .HasDefaultValueSql("GETDATE()");
            
            builder.Property(a => a.UpdatedAt)
                    .HasDefaultValueSql("GETDATE()");
        }
    }
}
