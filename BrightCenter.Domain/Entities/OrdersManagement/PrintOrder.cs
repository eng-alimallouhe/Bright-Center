using BrightCenter.Domain.Entities.UsersManagement;
using BrightCenter.Domain.Enums;

namespace BrightCenter.Domain.Entities.OrdersManagement
{
    public class PrintOrder
    {
        //Primary Key:
        public int PrintOrderId { get; set; }

        //Foreign Key: CustomerId ==> one(Customer)-to-many(PrintOrder) relationship
        public int CustomerId { get; set; }

        //Foreign Key: EmployeeId ==> one(Employee)-to-many(PrintOrder) relationship
        public int EmployeeId { get; set; }

        public int StartPage { get; set; }
        public int EndPage { get; set; }
        public int CopiesCount { get; set; }
        public decimal CopyCost { get; set; }
        public decimal TotalCost { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public string FileUrl { get; set; } = string.Empty;
        public string FileName { get; set; } = string.Empty;

        //Soft Delete:
        public bool IsActive { get; set; }

        //Timestamp:    
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        //Navigation Properties: 
        public virtual Customer? Customer { get; set; }
        public virtual Employee? Employee { get; set; } 
    }
}
