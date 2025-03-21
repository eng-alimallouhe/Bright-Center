using BrightCenter.Domain.Entities.StockManagement;
using BrightCenter.Domain.Entities.UsersManagement;
using BrightCenter.Domain.Enums;

namespace BrightCenter.Domain.Entities.OrdersManagement
{
    public class RentalOrder
    {
        // Primary key:
        public int RentalOrderId { get; set; }

        //Foreign Key: CustomerId ==> one(Customer)-to-many(RentalOrder) relationship
        public int CustomerId { get; set; }

        //Foreign Key: EmployeeId ==> one(Employee)-to-many(RentalOrder) relationship
        public int EmployeeId { get; set; }

        //Foreign Key: BookId ==> one(Book)-to-many(RentalOrder) relationship
        public int BookId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal InitialCost { get; set; }
        public decimal LateCost { get; set; }
        public decimal TotalCost { get; set; }
        public DeliveryMethod DeliveryMethod { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public RentalStatus RentalStatus { get; set; }

        //Soft Delete:
        public bool IsActive { get; set; }

        //Timestamp:
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        //Navigation Porperties:
        public virtual Customer? Customer { get; set; }
        public virtual Employee? Employee { get; set; }
        public virtual Product? Book { get; set; }
    }
}
