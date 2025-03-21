using BrightCenter.Domain.Entities.EmployeesManagement;
using BrightCenter.Domain.Entities.OrdersManagement;
using BrightCenter.Domain.Entities.StockManagement;
using BrightCenter.Domain.Entities.UsersManagement;
using Microsoft.EntityFrameworkCore;

namespace BrightCenter.Infrastructure
{
    public class AppDbContext : DbContext
    {
        // UsersManagement Namespace
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<EmployeeDepartment> EmployeeDepartments { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Level> Levels { get; set; }

        //EmployeesManagement Namespace
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Leave> Leaves { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<LeaveBalance> LeaveBalances { get; set; }
        public DbSet<Incentive> Incentives { get; set; }
        public DbSet<Penalty> Penalties { get; set; }

        // OrdersManagement Namespace
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<SellOrder> SellOrders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<RentalOrder> RentalOrders { get; set; }
        public DbSet<PrintOrder> PrintOrders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<DeliveryOrder> DeliveryOrders { get; set; }

        // StockManagement Namespace
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<InventoryLog> InventoryLogs { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
}
