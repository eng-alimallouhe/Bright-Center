using BrightCenter.Domain.Entities.OrdersManagement;

namespace BrightCenter.Domain.Entities.StockManagement
{
    public class Book
    {
        //Primary Key:
        public int BookId { get; set; }

        //Foreign Key: ProductId ==> one(Product)-to-one(Book) relationship
        public int ProductId { get; set; }

        //Foreign Key: CategoryId ==> one(Genre)-to-many(Book) relationship
        public int GenreId { get; set; }

        //Foreign Key: AuthorId ==> one(Author)-to-many(Author) relationship
        public int AuthorId { get; set; }
        public string ISBN { get; set; } = string.Empty;
        public int Pages { get; set; }

        public int PublishedYear { get; set; }

        //Navigation Property: many-to-many
        public virtual ICollection<Publisher> Publishers { get; set; } = [];

        // Navigation property:
        public virtual Product? Product { get; set; }
        public virtual Genre? Genre { get; set; }
        public virtual Author? Author { get; set; }
        public virtual ICollection<RentalOrder> RentalOrders { get; set; } = [];
    }
}