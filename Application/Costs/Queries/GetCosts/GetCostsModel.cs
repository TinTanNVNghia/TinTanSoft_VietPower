using System;

namespace Application.Costs.Queries.GetCosts
{
    public class GetCostsModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CurrencyId { get; set; }
        public Decimal DefaultValue { get; set; }
        public bool CalculateCostByPercent { get; set; }
        public Decimal DefaultPercentValue { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}