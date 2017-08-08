using System;

namespace Application.QuotaBranchs.Queries.GetQuotaBranchs
{
    public class GetQuotaBranchsModel
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public Decimal QuotaExpense { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}