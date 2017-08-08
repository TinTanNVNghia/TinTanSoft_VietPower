using System;

namespace Domain
{
    public class SupplierProduct : IEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; } // Id San Pham
        public int SupplierId { get; set; } // Id Nha Cung Cap
        public string Code { get; set; } // Ma San Pham Cua Nha Cung Cap
        public string Name { get; set; } // Ten San Pham Cua Nha Cung Cap
        public string Description { get; set; } // Mo Ta
        public int CurrencyId { get; set; } // Id Tien Te
        public Decimal UnitPrice { get; set; } // Don Gia Cua Nha Cung Cap 
        public bool Active { get; set; } // Kich Hoat
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}
