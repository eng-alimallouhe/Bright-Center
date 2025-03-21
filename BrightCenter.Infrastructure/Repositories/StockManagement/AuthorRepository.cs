using BrightCenter.Domain.Entities.StockManagement;
using BrightCenter.Infrastructure.DbContexts;

namespace BrightCenter.Infrastructure.Repositories.StockManagement
{
    public class AuthorRepository : BaseRepository<Author>
    {
        private readonly AppDbContext _context;

        public AuthorRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public override async Task DeleteAsync(int id)
        {
            var author = await _context.Authors.FindAsync(id);
            if (author is not null)
            {
                author.IsActive = false;
                author.UpdatedAt = DateTime.Now;
                _context.Authors.Update(author);
                await SaveChangesAsync();
            }
            else
            {
                throw new KeyNotFoundException("Author not found");
            }
        }
    }
}
