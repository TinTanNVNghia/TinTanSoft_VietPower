using System;

namespace Domain
{
    public class Export : IEntity
    {
        public int Id { get; set; }
        public string Code { get; set; } // Ma Phieu Xuat
        public DateTime ExportDate { get; set; } // Ngay Xuat Kho
        public int WarehouseId { get; set; } // Id Kho
        public string Note { get; set; } // Ghi Chu
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}