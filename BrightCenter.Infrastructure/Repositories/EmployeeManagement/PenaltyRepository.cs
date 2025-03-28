﻿
using BrightCenter.Domain.Entities.EmployeesManagement;
using BrightCenter.Infrastructure.DbContexts;

namespace BrightCenter.Infrastructure.Repositories.EmployeeManagement
{
    public class PenaltyRepository : BaseRepository<Penalty>
    {
        private readonly AppDbContext _context;
        public PenaltyRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public override async Task DeleteAsync(int id)
        {
            var penalty = await _context.Penalties.FindAsync(id);
            if (penalty is not null)
            {
                penalty.IsActive = false;
                _context.Penalties.Update(penalty);
                await SaveChangesAsync();
            }
            else
            {
                throw new KeyNotFoundException("Penalty not found");
            }
        }
    }

}
