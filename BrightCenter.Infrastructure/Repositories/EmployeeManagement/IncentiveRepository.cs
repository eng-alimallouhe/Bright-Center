
using BrightCenter.Domain.Entities.EmployeesManagement;
using BrightCenter.Infrastructure.DbContexts;

namespace BrightCenter.Infrastructure.Repositories.EmployeeManagement
{
    public class IncentiveRepository : BaseRepository<Incentive>
    {
        private readonly AppDbContext _context;
        public IncentiveRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public override async Task DeleteAsync(int id)
        {
            var incentive = await _context.Incentives.FindAsync(id);
            if (incentive is not null)
            {
                incentive.IsActive = false;
                _context.Incentives.Update(incentive);
                await SaveChangesAsync();
            }
            else
            {
                throw new KeyNotFoundException("Incentive not found");
            }
        }
    }

}
