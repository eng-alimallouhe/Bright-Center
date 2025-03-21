using BrightCenter.Domain.Entities.OrdersManagement;
using BrightCenter.Domain.Entities.UsersManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrightCenter.Infrastructure.Configurations.OrderManagement
{
    public class CartConfigurations :
        IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasKey(c => c.CartId);

            builder.Property(c => c.CartId)
                    .ValueGeneratedOnAdd();

            builder.Property(c => c.IsCheckedOut)
                    .HasDefaultValue(false);

            builder.Property(c => c.CreatedAt)
                    .HasDefaultValueSql("GETDATE()");

            builder.Property(c => c.UpdatedAt)
                    .HasDefaultValueSql("GETDATE()");

            builder.HasOne(c => c.Customer)
                .WithOne(c => c.Cart)
                .HasForeignKey<Cart>(c => c.CustomerId);
        }
    }
}
