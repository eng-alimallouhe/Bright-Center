using BrightCenter.Domain.Entities.UsersManagement;
using BrightCenter.Domain.Enums;

namespace BrightCenter.Domain.Entities.OrdersManagement
{
    public class SellOrder
    {
        // Primary key:
        public int SellOrderId { get; set; }

        //Foreign Key: CustomerId ==> one(Customer)-to-many(SellOrder) relationship
        public int CustomerId { get; set; }

        //Foreign Key: EmployeeId ==> one(Employee)-to-many(SellOrder) relationship
        public int EmployeeId { get; set; }

        public decimal OrderCost { get; set; }
        public decimal DeliveryCost { get; set; }
        public decimal TotalCost { get; set; }
        public DateTime Date { get; set; }
        public DeliveryMethod DeliveryMethod { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public PaymentStatus PaymentStatus { get; set; }

        //Soft Delete:
        public bool IsActive { get; set; }

        //Timestamp:
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        
        // Navigation property:
        public Customer Customer { get; set; } = new Customer();
        public Employee Employee { get; set; } = new Employee();
        public   ICollection<OrderItem> OrderItems { get; set; } = [];
    }
}
