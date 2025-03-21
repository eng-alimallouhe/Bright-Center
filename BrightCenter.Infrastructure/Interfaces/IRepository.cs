using System.Linq.Expressions;

namespace BrightCenter.Infrastructure.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<ICollection<TEntity>> GettAllAsync();

        Task<TEntity?> GetByIdAsync(int id);

        Task<TEntity> AddAsync(TEntity entity);

        void UpdateAsync(TEntity entity);

        Task DeleteAsync(int id);

        Task SaveChangesAsync();

        Task<ICollection<TEntity>> GetByExp(Expression<Func<TEntity, bool>> expression);
    }
}
