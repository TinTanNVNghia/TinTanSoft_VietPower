using System;

namespace Application.Accounts.Queries.GetAccountById
{
    public class GetAccountByIdModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; } 
        public string Email { get; set; }
        public string Phone { get; set; }
        public string PhoneBackup { get; set; }
        public int Age { get; set; }
        public DateTime DayOfBirth { get; set; }
        public string GovernmentId { get; set; }
        public string Address { get; set; }
        public bool Active { get; set; }
        public string Note { get; set; }
        public int GenderId { get; set; }
        public int DepartmentId { get; set; }
        public int PositionId { get; set; }
        public int BranchId { get; set; }
        public int RoleId { get; set; }
        public int CompanyId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}