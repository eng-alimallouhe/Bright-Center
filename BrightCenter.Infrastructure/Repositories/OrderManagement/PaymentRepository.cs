using BrightCenter.Domain.Entities.OrdersManagement;
using BrightCenter.Infrastructure.DbContexts;

namespace BrightCenter.Infrastructure.Repositories.OrderManagement
{
    public class PaymentRepository : BaseRepository<Payment>
    {
        private readonly AppDbContext _context;
        public PaymentRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public override async Task DeleteAsync(int id)
        {
            var payment = await _context.Payments.FindAsync(id);
            if (payment is not null)
            {
                payment.IsActive = false;
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Payment not found");
            }
        }
    }
}
