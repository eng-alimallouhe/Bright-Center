using BrightCenter.Domain.Entities.UsersManagement;

namespace BrightCenter.Domain.Entities.OrdersManagement
{
    public class DeliveryOrder
    {
        //Primary Key:
        public int DeliveryOrderId { get; set; }

        //Foreign Key: CustomerId ==> one(Customer)-to-many(DeliveryOrder) relationship
        public int CustomerId{ get; set; }

        //Foreign Key: EmployeeId ==> one(Employee)-to-many(PrintOrder) relationship
        public int EmployeeId{ get; set; }

        //Foreign Key: AddressId ==> one(Address)-to-one(PrintOrder) relationship
        public int? AddressId { get; set; }

        public string OrderName { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;

        //Soft Delete:
        public bool IsActive { get; set; }

        //Timestamp:
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        //Navigation Properties:
        public virtual Customer? Customer { get; set; }
        public virtual Employee? Employee { get; set; }
        public virtual Address? Address { get; set; }
    }
}
