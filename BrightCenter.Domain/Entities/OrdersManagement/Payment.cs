using BrightCenter.Domain.Entities.UsersManagement;
using BrightCenter.Domain.Enums;

namespace BrightCenter.Domain.Entities.OrdersManagement
{
    public class Payment
    {
        //Primary Key:
        public int PaymentId { get; set; }

        //Foreign Key: CustomerId ==> one(Customer)-to-many(Payment) relationship
        public int CustomerId { get; set; }

        //Foreign Key: EmployeeId ==> one(Employee)-to-many(PrintOrder) relationship
        public int EmployeeId { get; set; }

        public DateTime DateTime { get; set; }
        public Service Service { get; set; } //ENum: SellOrder, RentalOrder, PrintOrder, DeliveryOrder
        public int ServiceId { get; set; } // Foreign key to the specific service table
        public decimal Amount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public PaymentStatus PaymentStatus { get; set; }

        //Soft Delete:
        public bool IsActive { get; set; }

        //Timestamp:
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        //Navigation Preperties: 
        public virtual Customer? Customer { get; set; }
        public virtual Employee? Employee { get; set; }
    }
}
