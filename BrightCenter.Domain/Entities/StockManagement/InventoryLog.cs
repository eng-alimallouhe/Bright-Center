using BrightCenter.Domain.Enums;

namespace BrightCenter.Domain.Entities.StockManagement
{
    public class InventoryLog
    {
        // Primary key:
        public int InventoryLogId { get; set; }

        // Foreign key:
        public int ProductId { get; set; }

        public DateTime LogDate { get; set; }

        public LogType ChangeType { get; set; }
        public int ChangedQuantity { get; set; }

        // Navigation property:
        public virtual Product? Product { get; set; }
    }
}