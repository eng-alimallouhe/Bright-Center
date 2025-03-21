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
        public User User { get; set; } = new User();    
        public   Cart Cart { get; set; } = new Cart();
        public   Level Level { get; set; } = new Level();
        public   ICollection<SellOrder> SellOrders { get; set; } = [];
        public   ICollection<RentalOrder> RentalOrders { get; set; } = [];
        public   ICollection<PrintOrder> PrintOrders { get; set; } = [];
        public   ICollection<Payment> Payments { get; set; } = [];
        public   ICollection<DeliveryOrder> DeliveryOrders { get; set; } = [];
        public   ICollection<Address> Addresses { get; set; } = [];
    }
}