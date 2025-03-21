using BrightCenter.Domain.Entities.OrdersManagement;
using BrightCenter.Infrastructure.DbContexts;

namespace BrightCenter.Infrastructure.Repositories.OrderManagement
{
    public class CartItemRepository : BaseRepository<CartItem>
    {
        private readonly AppDbContext _context;
        public CartItemRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public override async Task DeleteAsync(int id)
        {
            var cartItem = await _context.CartItems.FindAsync(id);
            if (cartItem is not null)
            {
                _context.CartItems.Remove(cartItem);
            }
            else
            {
                throw new Exception("CartItem not found");
            }
        }
    }
}
