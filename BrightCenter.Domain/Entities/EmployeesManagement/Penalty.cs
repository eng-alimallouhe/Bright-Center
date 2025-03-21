using BrightCenter.Domain.Entities.UsersManagement;

namespace BrightCenter.Domain.Entities.EmployeesManagement
{
    public class Penalty    
    {
        //primary key
        public int PenaltyId { get; set; }

        //Foreign Key: EmployeeId ==> one(employee)-to-many(penalties) relationship
        public int EmployeeId { get; set; }
        
        public decimal Amount { get; set; }
        public string DecisionFileUrl { get; set; } = string.Empty;
        public string Reason { get; set; } = string.Empty;
        public DateTime Date { get; set; }

        //Soft delete
        public bool IsActive { get; set; }

        //Navigation Property:
        public virtual Employee? Employee { get; set; }
    }
}