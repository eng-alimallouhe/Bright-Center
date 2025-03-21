using BrightCenter.Domain.Entities.OrdersManagement;
using BrightCenter.Infrastructure.DbContexts;

namespace BrightCenter.Infrastructure.Repositories.OrderManagement
{
    public class SellOrderRepository : BaseRepository<SellOrder>
    {
        private readonly AppDbContext _context;
        public SellOrderRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public override async Task DeleteAsync(int id)
        {
            var sellOrder = await _context.SellOrders.FindAsync(id);
            if (sellOrder is not null)
            {
                sellOrder.IsActive = false;
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("SellOrder not found");
            }
        }
    }
}
