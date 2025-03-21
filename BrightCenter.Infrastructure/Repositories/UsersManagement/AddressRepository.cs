using BrightCenter.Domain.Entities.UsersManagement;
using BrightCenter.Infrastructure.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightCenter.Infrastructure.Repositories.UsersManagement
{

    public class AddressRepository : BaseRepository<Address>
    {
        private readonly AppDbContext _context;
        public AddressRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public override async Task DeleteAsync(int id)
        {
            var address = await _context.Addresses.FindAsync(id);
            if (address != null)
            {
                _context.Addresses.Remove(address);
                await SaveChangesAsync();
            }
            else
            {
                throw new Exception("Address not found");
            }
        }
    }
}
