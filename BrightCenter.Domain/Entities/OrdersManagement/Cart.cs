using BrightCenter.Domain.Entities.UsersManagement;

namespace BrightCenter.Domain.Entities.OrdersManagement
{
    public class Cart
    {
        // Primary key:
        public int CartId { get; set; }

        //Foreign Key: CustomerId ==> one(Cart)-to-one(Customer) relationship
        public int CustomerId { get; set; }

        public bool IsCheckedOut { get; set; }

        //Timestamp:
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Navigation property:
        public Customer? Customer { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; } = [];
    }
}
