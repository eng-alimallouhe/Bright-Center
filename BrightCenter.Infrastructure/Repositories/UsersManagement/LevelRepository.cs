﻿using BrightCenter.Domain.Entities.UsersManagement;
using BrightCenter.Infrastructure.DbContexts;

namespace BrightCenter.Infrastructure.Repositories.UsersManagement
{
    public class LevelRepository : BaseRepository<Level>
    {
        private readonly AppDbContext _context;
        public LevelRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public override async Task DeleteAsync(int id)
        {
            var level = await _context.Levels.FindAsync(id);
            if (level != null)
            {
                level.IsActive = false;
                _context.Levels.Update(level);
                await SaveChangesAsync();
            }
            else
            {
                throw new Exception("Level not found");
            }
        }
    }
}
