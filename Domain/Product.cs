using System;

namespace Domain
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Code { get; set; } // Ma San Pham
        public string Name { get; set; } // Ten San Pham
        public string Description { get; set; } // Ghi Chu
        public string Production { get; set; } // Nha San Xuat
        public int CategoryId { get; set; } // Id Danh Muc San Pham
        public int CurrencyId { get; set; } // Id Tien Te
        public int CompanyId { get; set; } // Id Cong Ty
        public int UnitId { get; set; } // Don Vi Tinh
        public Decimal InUintPrice { get; set; } // Gia Nhap
        public Decimal OutUnitPrice { get; set; } // Gia Ban
        public Decimal BaseUnitPrice { get; set; } // Gia Von
        public Decimal QuotaWarehouse { get; set; } // Ton Kho Toi Thieu San Pham
        public bool Active { get; set; } // Kich Hoat
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}