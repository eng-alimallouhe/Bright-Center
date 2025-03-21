
using BrightCenter.Domain.Entities.EmployeesManagement;
using BrightCenter.Infrastructure.DbContexts;

namespace BrightCenter.Infrastructure.Repositories.EmployeeManagement
{
    public class LeaveBalanceRepository : BaseRepository<LeaveBalance>
    {
        private readonly AppDbContext _context;
        public LeaveBalanceRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public override async Task DeleteAsync(int id)
        {
            var leaveBalance = await _context.LeaveBalances.FindAsync(id);
            if (leaveBalance is not null)
            {
                _context.LeaveBalances.Remove(leaveBalance);
                await SaveChangesAsync();
            }
            else
            {
                throw new KeyNotFoundException("LeaveBalance not found");
            }
        }
    }

}
