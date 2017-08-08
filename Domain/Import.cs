using System;

namespace Domain
{
    public class Import : IEntity
    {
        public int Id { get; set; }
        public string Code { get; set; } // Ma Phieu Nhap
        public DateTime ImportDate { get; set; } // Ngay Nhap Kho
        public int WarehouseId { get; set; } // Id Kho
        public string Note { get; set; } // Ghi Chu
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}