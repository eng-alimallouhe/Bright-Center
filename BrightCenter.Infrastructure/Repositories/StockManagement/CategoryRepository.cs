using BrightCenter.Domain.Entities.StockManagement;
using BrightCenter.Infrastructure.DbContexts;

namespace BrightCenter.Infrastructure.Repositories.StockManagement
{
    public class CategoryRepository : BaseRepository<Category>
    {
        private readonly AppDbContext _context;
        public CategoryRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public override async Task DeleteAsync(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category is not null)
            {
                category.IsActive = false;
                category.UpdatedAt = DateTime.UtcNow;
                _context.Categories.Update(category);
                await SaveChangesAsync();
            }
            else
            {
                throw new KeyNotFoundException("Category not found");
            }
        }
    }
}
