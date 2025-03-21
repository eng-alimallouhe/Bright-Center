using BrightCenter.Domain.Entities.StockManagement;
using BrightCenter.Infrastructure.DbContexts;

namespace BrightCenter.Infrastructure.Repositories.StockManagement
{
    public class GenreRepository : BaseRepository<Genre>
    {
        private readonly AppDbContext _context;
        public GenreRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public override async Task DeleteAsync(int id)
        {
            var genre = await _context.Genres.FindAsync(id);
            if (genre is not null)
            {
                genre.IsActive = false;
                genre.UpdatedAt = DateTime.UtcNow;
                _context.Genres.Update(genre);
                await SaveChangesAsync();
            }
            else
            {
                throw new KeyNotFoundException("Genre not found");
            }
        }
    }
}
