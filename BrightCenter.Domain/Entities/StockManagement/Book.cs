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
        public decimal RentalCost { get; set; }
        public int PublishedYear { get; set; }

        //Navigation Property: many-to-many
        public   ICollection<Publisher> Publishers { get; set; } = [];

        // Navigation property:
        public   Product  Product { get; set; } = new Product();
        public Genre Genre { get; set; } = new Genre();
        public Author Author { get; set; } = new Author();
        public   ICollection<RentalOrder> RentalOrders { get; set; } = [];
    }
}