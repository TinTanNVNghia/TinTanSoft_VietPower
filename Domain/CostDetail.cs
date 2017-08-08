using System;

namespace Domain
{
    public class CostDetail : IEntity
    {
        public int Id { get; set; }
        public int CostId { get; set; }
        public int SaleId { get; set; }
        public Decimal CostValue { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}