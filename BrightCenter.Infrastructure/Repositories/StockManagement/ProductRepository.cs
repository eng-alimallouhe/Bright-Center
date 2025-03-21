using BrightCenter.Domain.Entities.StockManagement;
using BrightCenter.Infrastructure.DbContexts;

namespace BrightCenter.Infrastructure.Repositories.StockManagement
{
    public class ProductRepository : BaseRepository<Product>
    {
        private readonly AppDbContext _context;
        public ProductRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public override async Task DeleteAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product is not null)
            {
                product.IsActive = false;
                product.UpdatedAt = DateTime.UtcNow;
                _context.Products.Update(product);
                await SaveChangesAsync();
            }
            else
            {
                throw new KeyNotFoundException("Product not found");
            }
        }
    }
}
