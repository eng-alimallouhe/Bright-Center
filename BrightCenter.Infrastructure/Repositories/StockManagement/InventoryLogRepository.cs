using BrightCenter.Domain.Entities.StockManagement;
using BrightCenter.Infrastructure.DbContexts;

namespace BrightCenter.Infrastructure.Repositories.StockManagement
{

    public class InventoryLogRepository : BaseRepository<InventoryLog>
    {
        private readonly AppDbContext _context;
        public InventoryLogRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public override async Task DeleteAsync(int id)
        {
            var inventoryLog = await _context.InventoryLogs.FindAsync(id);
            if (inventoryLog is not null)
            {
                _context.InventoryLogs.Remove(inventoryLog);
                await SaveChangesAsync();
            }
            else
            {
                throw new KeyNotFoundException("InventoryLog not found");
            }
        }
    }
}
