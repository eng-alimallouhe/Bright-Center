using BrightCenter.Infrastructure.DbContexts;
using BrightCenter.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BrightCenter.Infrastructure.Repositories
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public BaseRepository(AppDbContext context)
        {
            this._context = context;
            this._dbSet = context.Set<TEntity>();
        }
        public async Task<ICollection<TEntity>> GettAllAsync()
        {
            return await _dbSet.ToListAsync();
        }


        public async Task<TEntity?> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }


        public void UpdateAsync(TEntity entity)
        {
            _dbSet.Update(entity);
        }
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity).AsTask();
            return entity;
        }

        public abstract Task DeleteAsync(int id);

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<ICollection<TEntity>> GetByExp(Expression<Func<TEntity, bool>> expression)
        {
            return await _dbSet.Where(expression).ToListAsync();
        }
    }
}
