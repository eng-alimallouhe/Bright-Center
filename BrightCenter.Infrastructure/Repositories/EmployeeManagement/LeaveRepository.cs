
using BrightCenter.Domain.Entities.EmployeesManagement;
using BrightCenter.Infrastructure.DbContexts;

namespace BrightCenter.Infrastructure.Repositories.EmployeeManagement
{
    public class LeaveRepository : BaseRepository<Leave>
    {
        private readonly AppDbContext _context;
        public LeaveRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public override async Task DeleteAsync(int id)
        {
            var leave = await _context.Leaves.FindAsync(id);
            if (leave is not null)
            {
                leave.IsActive = false;
                _context.Leaves.Update(leave);
                await SaveChangesAsync();
            }
            else
            {
                throw new KeyNotFoundException("Leave not found");
            }
        }
    }

}
