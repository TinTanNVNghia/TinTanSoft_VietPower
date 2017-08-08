using System;

namespace Domain
{
    public class ExportDetail : IEntity
    {
        public int Id { get; set; }
        public int ExportId { get; set; } // Id Phieu Xuat Kho
        public int ProductId { get; set; } // Id San Pham
        public int SupplierId { get; set; } // Id Nha Cung Cap        
        public int Quantity { get; set; } // So Luong
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}