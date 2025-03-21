using BrightCenter.Domain.Entities.UsersManagement;

namespace BrightCenter.Domain.Entities.EmployeesManagement
{
    public class Incentive
    {
        //primary key
        public int IncentiveId { get; set; }

        //Foreign Key: EmployeeId ==> one(employee)-to-many(incentives) relationship
        public int EmployeeId { get; set; }
       
        public decimal Amount { get; set; }
        public string Reason { get; set; } = string.Empty;
        public string DecisionFileUrl { get; set; } = string.Empty;
        public DateTime Date { get; set; }

        //Navigation Property:
        public virtual Employee? Employee { get; set; }
    }
}