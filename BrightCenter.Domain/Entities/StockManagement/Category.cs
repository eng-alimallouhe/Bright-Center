namespace BrightCenter.Domain.Entities.StockManagement
{
    public class Category
    {
        // Primary key:
        public int CategoryId { get; set; }

        public string CategoryName { get; set; } = string.Empty;
        public string CategoryDescription { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        //soft delete
        public bool IsActive { get; set; }

        // Navigation property:
        public virtual ICollection<Product> Products { get; set; } = [];
    }
}