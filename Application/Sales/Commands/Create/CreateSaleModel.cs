using System;

namespace Application.Sales.Commands.Create
{
    public class CreateSaleModel
    {
        public int CustomerId { get; set; }
        public DateTime SaleDate { get; set; }
        public Decimal Total { get; set; }
        public Decimal TaxValue { get; set; }
        public Decimal CostValue { get; set; }
        public Decimal Discount { get; set; }
        public Decimal Paid { get; set; }
        public string Note { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}