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
        public virtual User? User { get; set; }
        public virtual ICollection<EmployeeDepartment> EmployeeDepartments { get; set; } = [];
        public virtual ICollection<Attendance> Attendances { get; set; } = [];
        public virtual ICollection<Leave> Leaves { get; set; } = [];
        public virtual ICollection<Salary> Salaries { get; set; } = [];
        public virtual ICollection<LeaveBalance> LeaveBalances { get; set; } = [];
        public virtual ICollection<Incentive> Incentives { get; set; } = [];
        public virtual ICollection<Penalty> Penalties { get; set; } = [];
        public virtual ICollection<SellOrder>? SellOrders { get; set; } = [];
        public virtual ICollection<RentalOrder>? RentalOrders { get; set; } = [];
        public virtual ICollection<PrintOrder>? PrintOrders { get; set; } = [];
        public virtual ICollection<Payment>? Payments { get; set; } = [];
        public virtual ICollection<DeliveryOrder>? DeliveryOrders { get; set; } = [];
    }
}