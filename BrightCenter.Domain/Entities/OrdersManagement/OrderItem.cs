using BrightCenter.Domain.Entities.StockManagement;

namespace BrightCenter.Domain.Entities.OrdersManagement
{
    public class OrderItem
    {
        // Primary key:
        public int OrderItemId { get; set; }

        //Foreign Key: SellOrderId ==> one(SellOrder)-to-many(OrderItem) relationship
        public int SellOrderId { get; set; }

        //Foreign Key: ProductId ==> one(Product)-to-many(OrderItem) relationship
        public int ProductId { get; set; }
       
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalPrice { get; set; }
       
        //Soft Delete:
        public bool IsActive { get; set; }

        //Timestamp:
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Navigation property:
        public virtual SellOrder? SellOrder { get; set; }
        public virtual Product? Product { get; set; }
    }
}
