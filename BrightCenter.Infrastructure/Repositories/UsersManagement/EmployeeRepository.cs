using BrightCenter.Domain.Entities.UsersManagement;
using BrightCenter.Infrastructure.DbContexts;

namespace BrightCenter.Infrastructure.Repositories.UsersManagement
{
    public class EmployeeRepository : BaseRepository<Employee>
    {
        private readonly UserRepositoy _userRepositoy;
        public EmployeeRepository(
            AppDbContext context,
            UserRepositoy userRepositoy)
            : base(context)
        {
            _userRepositoy = userRepositoy;
        }
        public override async Task DeleteAsync(int id)
        {
            await _userRepositoy.DeleteAsync(id);
            await SaveChangesAsync();
        }
    }
}
