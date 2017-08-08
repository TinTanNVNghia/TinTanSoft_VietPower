using System;

namespace Application.Incomes.Queries.GetIncomes
{
    public class GetIncomesModel
    {
        public int Id { get; set; }
        public DateTime IncomeDate { get; set; }
        public int IncomeAccountId { get; set; }
        public int IncomeCategoryId { get; set; }
        public int BranchId { get; set; }
        public Decimal Value { get; set; }
        public int CurrencyId { get; set; }
        public string Note { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}