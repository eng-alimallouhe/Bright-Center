namespace BrightCenter.Domain.Entities.UsersManagement
{
    public class Level
    {
        //Primary Key:
        public int LevelId { get; set; }
        
        public string LevelName { get; set; } = string.Empty;
        public int RequiredPoints { get; set; }
        public decimal DiscountPercentage { get; set; }
        public string LevelDescription { get; set; } = string.Empty;

        //Soft Delete:
        public bool IsActive { get; set; }

        //Timestamp:
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        //Navigation Property:
        public ICollection<User> Users { get; set; } = [];
    }
}