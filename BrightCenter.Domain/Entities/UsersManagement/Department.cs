namespace BrightCenter.Domain.Entities.UsersManagement
{
    public class Department
    {
        //primary key
        public int DepartmentId { get; set; }
       
        public string DepartmentName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        
        //soft delete:
        public bool IsActive { get; set; }
        
        //Timestamp:
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        //Navigation Property:
        public virtual ICollection<EmployeeDepartment> EmployeeDepartments { get; set; } = [];
    }
}