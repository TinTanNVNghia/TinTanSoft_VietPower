using System;

namespace Domain
{
    public class CustomerType : IEntity
    {
        public int Id { get; set; }
        public string Code { get; set; } // Ma Nhom Khach Hang
        public string Name { get; set; } // Ten Nhom Khach Hang
        public string Description { get; set; } // Mo Ta
        public bool Active { get; set; } // Kich Hoat
        public int CompanyId { get; set; } // Id Cong Ty
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}
