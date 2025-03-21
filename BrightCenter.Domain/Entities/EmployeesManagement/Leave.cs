using BrightCenter.Domain.Entities.UsersManagement;
using BrightCenter.Domain.Enums;

namespace BrightCenter.Domain.Entities.EmployeesManagement
{
    public class Leave
    {
        //primary key
        public int LeaveId { get; set; }

        //Foreign Key: EmployeeId ==> one(employee)-to-many(leaves) relationship
        public int EmployeeId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public LeaveType LeaveType { get; set; }
        public string Reason { get; set; } = string.Empty;
        public bool IsApproved { get; set; }
        public bool IsPaid { get; set; }

        //Navigation Property:
        public virtual Employee? Employee { get; set; }
    }
}