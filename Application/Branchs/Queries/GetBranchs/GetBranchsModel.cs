using System;

namespace Application.Branchs.Queries.GetBranchs
{
    public class GetBranchsModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string PhoneBackup { get; set; }
        public string TaxNumber { get; set; }
        public string BankAccountName { get; set; }
        public string BankAccountNumber { get; set; }
        public string BankName { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public int BranchAccountId { get; set; }
        public int BranchParentId { get; set; }
        public DateTime CreatedAt { get; set; } 
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}