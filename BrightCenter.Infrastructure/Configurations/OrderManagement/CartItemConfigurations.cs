using BrightCenter.Domain.Entities.OrdersManagement;
using BrightCenter.Domain.Entities.UsersManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrightCenter.Infrastructure.Configurations.OrderManagement
{
    public class CartItemConfigurations :
        IEntityTypeConfiguration<CartItem>
    {
        public void Configure(EntityTypeBuilder<CartItem> builder)
        {
            builder.HasKey(ci => ci.CartItemId);
            
            builder.Property(ci => ci.CartItemId)
                    .ValueGeneratedOnAdd();

            builder.Property(ci => ci.Quantity)
                    .IsRequired();
            
            builder.Property(ci => ci.UnitPrice)
                    .HasColumnType("decimal(7, 2)");
            
            builder.Property(ci => ci.TotalPrice)
                    .HasColumnType("decimal(7, 2)");
            
            builder.Property(ci => ci.CreatedAt)
                    .HasDefaultValueSql("GETDATE()");
            
            builder.Property(ci => ci.UpdatedAt)
                    .HasDefaultValueSql("GETDATE()");
            
            builder.HasOne(ci => ci.Cart)
                .WithMany(c => c.CartItems)
                .HasForeignKey(ci => ci.CartId);
            
            builder.HasOne(ci => ci.Product)
                .WithMany(p => p.CartItems)
                .HasForeignKey(ci => ci.ProductId);
        }
    }
}
