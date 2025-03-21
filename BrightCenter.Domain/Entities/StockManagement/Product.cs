using BrightCenter.Domain.Entities.OrdersManagement;

namespace BrightCenter.Domain.Entities.StockManagement
{
    public class Product
    {
        // Primary key:
        public int ProductId { get; set; }

        // Foreign key:
        public int CategoryId { get; set; }

        public string ProductName { get; set; } = string.Empty;
        public string ProductDescription { get; set; } = string.Empty;
        public decimal ProductPrice { get; set; }
        public int ProductStock { get; set; }

        //soft delete
        public bool IsActive { get; set; }

        //Timestamp:
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Navigation property:
        public Category Category { get; set; } = new Category();
        public   ICollection<Discount> Discounts { get; set; } = [];
        public   ICollection<InventoryLog> InventoryLogs { get; set; } = [];
        public   ICollection<CartItem> CartItems { get; set; } = [];
    }
}