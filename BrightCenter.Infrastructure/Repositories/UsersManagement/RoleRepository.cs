﻿using BrightCenter.Domain.Entities.UsersManagement;
using BrightCenter.Infrastructure.DbContexts;

namespace BrightCenter.Infrastructure.Repositories.UsersManagement
{
    public class RoleRepository : BaseRepository<Role>
    {
        private readonly AppDbContext _context;
        public RoleRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public override async Task DeleteAsync(int id)
        {
            var role = await _context.Roles.FindAsync(id);
            if (role != null)
            {
                role.IsActive = false;
                _context.Roles.Update(role);
                await SaveChangesAsync();
            }
            else
            {
                throw new Exception("Role not found");
            }
        }
    }
}
