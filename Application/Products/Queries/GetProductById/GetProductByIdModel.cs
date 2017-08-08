using System;

namespace Application.Products.Queries.GetProductById
{
    public class GetProductByIdModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Production { get; set; }
        public string CategoryName { get; set; }
        public string CategoryCode { get; set; }
        public string CurrencyCode { get; set; }
        public string Unit { get; set; }
        public Decimal InUintPrice { get; set; }
        public Decimal OutUnitPrice { get; set; }
        public Decimal BaseUnitPrice { get; set; }
        public Decimal QuotaWarehouse { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}