using BrightCenter.Domain.Entities.StockManagement;
using BrightCenter.Infrastructure.DbContexts;

namespace BrightCenter.Infrastructure.Repositories.StockManagement
{
    public class SupplierRepository : BaseRepository<Supplier>
    {
        private readonly AppDbContext _context;
        public SupplierRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public override async Task DeleteAsync(int id)
        {
            var supplier = await _context.Suppliers.FindAsync(id);
            if (supplier is not null)
            {
                supplier.IsActive = false;
                supplier.UpdatedAt = DateTime.UtcNow;
                _context.Suppliers.Update(supplier);
                await SaveChangesAsync();
            }
            else
            {
                throw new KeyNotFoundException("Supplier not found");
            }
        }
    }
}
