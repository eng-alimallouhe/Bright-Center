using BrightCenter.Domain.Entities.OrdersManagement;
using BrightCenter.Infrastructure.DbContexts;

namespace BrightCenter.Infrastructure.Repositories.OrderManagement
{
    public class RentalOrderRepository : BaseRepository<RentalOrder>
    {
        private readonly AppDbContext _context;
        public RentalOrderRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public override async Task DeleteAsync(int id)
        {
            var rentalOrder = await _context.RentalOrders.FindAsync(id);
            if (rentalOrder is not null)
            {
                rentalOrder.IsActive = false;
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("RentalOrder not found");
            }
        }
    }
}
