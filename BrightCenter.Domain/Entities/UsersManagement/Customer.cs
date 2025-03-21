using BrightCenter.Domain.Entities.OrdersManagement;

namespace BrightCenter.Domain.Entities.UsersManagement
{
    public class Customer
    {
        //primary key
        public int CustomerId { get; set; }

        //Foreign Key: UserId ==> one(customer)-to-one(user) relationship
        public int UserId { get; set; }

        //Foreign Key: LevelId ==> one(customer)-to-one(level) relationship
        public int LevelId { get; set; }
        
        public decimal Points { get; set; }

        //Navigation Property:
        public virtual User? User { get; set; }
        public virtual Cart? Cart { get; set; }
        public virtual Level? Level { get; set; }
        public virtual ICollection<SellOrder> SellOrders { get; set; } = [];
        public virtual ICollection<RentalOrder> RentalOrders { get; set; } = [];
        public virtual ICollection<PrintOrder> PrintOrders { get; set; } = [];
        public virtual ICollection<Payment> Payments { get; set; } = [];
        public virtual ICollection<DeliveryOrder> DeliveryOrders { get; set; } = [];
    }
}