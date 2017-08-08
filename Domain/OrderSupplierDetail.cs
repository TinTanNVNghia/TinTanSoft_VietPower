using System;

namespace Domain
{
    public class OrderSupplierDetail : IEntity
    {
        public int Id { get; set; }
        public int OrderId { get; set; } // Id Don Dat Hang
        public int SupplierId { get; set; } // Id Nha Cung Cap
        public int ProductId { get; set; } // Id San Pham
        public Decimal Quantity { get; set; } // So Luong
        public Decimal UnitPrice { get; set; } // Don Gia
        public Decimal TaxId { get; set; } // Ma Thue
        public Decimal TaxValue { get; set; } // Tien Thue
        public Decimal Deduction { get; set; } // Chiet Khau
        public Decimal Total { get; set; } // Thanh Tien
        public string Note { get; set; } // Ghi Chu
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}