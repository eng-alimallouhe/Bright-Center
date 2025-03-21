using BrightCenter.Domain.Entities.EmployeesManagement;
using BrightCenter.Domain.Entities.OrdersManagement;

namespace BrightCenter.Domain.Entities.UsersManagement
{
    public class Employee
    {
        //primary key
        public int EmployeeId { get; set; }

        //Foreign Key: UserId ==> one(employee)-to-one(user) relationship
        public int UserId { get; set; }
        
        public DateTime HireDate { get; set; }
        public decimal BaseSalary { get; set; }

        //Navigation Property:
        public  User? User { get; set; }
        public   ICollection<EmployeeDepartment> EmployeeDepartments { get; set; } = [];
        public   ICollection<Attendance> Attendances { get; set; } = [];
        public   ICollection<Leave> Leaves { get; set; } = [];
        public   ICollection<Salary> Salaries { get; set; } = [];
        public   ICollection<LeaveBalance> LeaveBalances { get; set; } = [];
        public   ICollection<Incentive> Incentives { get; set; } = [];
        public   ICollection<Penalty> Penalties { get; set; } = [];
        public   ICollection<SellOrder>? SellOrders { get; set; } = [];
        public   ICollection<RentalOrder>? RentalOrders { get; set; } = [];
        public   ICollection<PrintOrder>? PrintOrders { get; set; } = [];
        public   ICollection<Payment>? Payments { get; set; } = [];
        public   ICollection<DeliveryOrder>? DeliveryOrders { get; set; } = [];
    }
}