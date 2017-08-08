using System;

namespace Domain
{
    public class TaxDetail : IEntity
    {
        public int Id { get; set; }
        public int TaxId { get; set; }
        public int SaleId { get; set; }
        public Decimal TaxValue { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}