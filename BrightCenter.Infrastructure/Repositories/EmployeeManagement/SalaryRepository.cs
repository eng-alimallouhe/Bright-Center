
using BrightCenter.Domain.Entities.EmployeesManagement;
using BrightCenter.Infrastructure.DbContexts;

namespace BrightCenter.Infrastructure.Repositories.EmployeeManagement
{
    public class SalaryRepository : BaseRepository<Salary>
    {
        private readonly AppDbContext _context;
        public SalaryRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public override async Task DeleteAsync(int id)
        {
            var salary = await _context.Salaries.FindAsync(id);
            if (salary is not null)
            {
                salary.IsActive = false;
                _context.Salaries.Update(salary);
                await SaveChangesAsync();
            }
            else
            {
                throw new KeyNotFoundException("Salary not found");
            }
        }
    }

}
