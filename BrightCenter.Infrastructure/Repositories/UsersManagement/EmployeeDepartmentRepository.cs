﻿using BrightCenter.Domain.Entities.UsersManagement;
using BrightCenter.Infrastructure.DbContexts;

namespace BrightCenter.Infrastructure.Repositories.UsersManagement
{
    public class EmployeeDepartmentRepository : BaseRepository<EmployeeDepartment>
    {
        private readonly AppDbContext _context;
        public EmployeeDepartmentRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public override async Task DeleteAsync(int id)
        {
            var employeeDepartment = await _context.EmployeeDepartments.FindAsync(id);
            if (employeeDepartment != null)
            {
                employeeDepartment.IsActive = false;
                _context.EmployeeDepartments.Update(employeeDepartment);
                await SaveChangesAsync();
            }
            else
            {
                throw new Exception("EmployeeDepartment not found");
            }
        }


    }
}
