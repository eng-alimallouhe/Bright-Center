namespace BrightCenter.Domain.Entities.UsersManagement
{
    public class User
    {
        //primary key
        public int UserId { get; set; }

        //Foreign Key: RoleId ==> one(role)-to-many(users) relationship
        public int RoleId { get; set; }
        
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        //locke user account:
        public bool IsLocked { get; set; }  

        //soft delete:
        public bool IsDeleted { get; set; }

        //Timestamp:
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime LastLogIn { get; set; }
        
        //Navigation Property:
        public virtual Role? Role { get; set; }
    }
}