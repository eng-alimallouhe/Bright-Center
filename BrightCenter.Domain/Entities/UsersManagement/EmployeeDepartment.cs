namespace BrightCenter.Domain.Entities.UsersManagement
{
    public class EmployeeDepartment
    {
        //primary key
        public int EmployeeDepartmentId { get; set; }
        
        //Foreign Key: EmployeeId ==> one(employee)-to-many(departments) relationship
        public int EmployeeId { get; set; }
        
        //Foreign Key: DepartmentId ==> one(department)-to-many(employees) relationship
        public int DepartmentId { get; set; }

        public string AppointmentDecisionUrl { get; set; } = string.Empty;

        //Soft Delete:
        public bool IsActive { get; set; }

        //Timestamp:
        public DateTime StartDate { get; set; } 
        public DateTime? EndDate { get; set; }

        //Navigation Property:
        public   Employee Employee { get; set; } = new Employee();
        public   Department Department { get; set; } = new Department();
    }
}