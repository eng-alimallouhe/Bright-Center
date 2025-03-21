using BrightCenter.Domain.Entities.UsersManagement;
using BrightCenter.Infrastructure.DbContexts;

internal class Program
{
    private static void Main(string[] args)
    {
        using (AppDbContext context = new AppDbContext())
        {
            context.Database.EnsureCreated();

            Console.WriteLine("Database created");

            context.Roles.Update(new Role 
            {
                RoleId=2,
                RoleType = "Not Admin",
                IsActive = false,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            });

            context.SaveChanges();
            Console.WriteLine("Press any key to exit...");
        }
    }
}