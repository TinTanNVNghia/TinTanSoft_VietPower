using System;

namespace Domain
{
    public class SaleDetail : IEntity
    {
        public int Id { get; set; }
        public int SaleId { get; set; } // Id Ban Hang
        public int ProductId { get; set; } // Id San Pham
        public Decimal UnitPrice { get; set; } // Don Gia
        public Decimal Quantity { get; set; } // So Luong
        public int TaxId { get; set; } // Id Tien Thue
        public Decimal TaxValue { get; set; } // Gia Tri Tien Thue
        public bool CalculateTaxByPercent { get; set; } // Tinh Tien Thue Theo Phan Tram
        public int CostId { get; set; } // Id Tien Phi
        public Decimal CostValue { get; set; } // Gia Tri Tien Phi
        public bool CalculateCostByPercent { get; set; } // Tinh Tien Phi Theo Phan Tram
        public Decimal Discount { get; set; } // Giam Gia Tinh Truc Tiep Ra Tien Mat
        public Decimal DiscountPercent { get; set; } // Phan Tram Giam Gia
        public Decimal Total { get; set; } // Tong Tien
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}
