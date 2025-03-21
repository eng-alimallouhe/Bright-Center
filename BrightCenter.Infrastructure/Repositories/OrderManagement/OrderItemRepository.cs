using BrightCenter.Domain.Entities.OrdersManagement;
using BrightCenter.Infrastructure.DbContexts;

namespace BrightCenter.Infrastructure.Repositories.OrderManagement
{
    public class OrderItemRepository : BaseRepository<OrderItem>
    {
        private readonly AppDbContext _context;
        public OrderItemRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public override async Task DeleteAsync(int id)
        {
            var orderItem = await _context.OrderItems.FindAsync(id);
            if (orderItem is not null)
            {
                orderItem.IsActive = false;
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("OrderItem not found");
            }
        }
    }
}
