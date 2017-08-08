using System;

namespace Application.OrderSuppliers.Queries.GetOrderSuppliers
{
    public class GetOrderSuppliersModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderAccountId { get; set; }
        public bool OrderFromOneSupplier { get; set; }
        public Decimal TotalDefault { get; set; }
        public Decimal OrtherPlus { get; set; }
        public Decimal OrtherMinus { get; set; }
        public Decimal TotalAfter { get; set; }
        public string Note { get; set; }
        public DateTime CreatedAt { get; set; } 
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}