using System;

namespace Domain
{
    public class ProductCategory : IEntity
    {
        public int Id { get; set; }
        public string Code { get; set; } // Ma Danh Muc San Pham
        public string Name { get; set; } // Ten Danh Muc San Pham
        public string Description { get; set; } // Mo Ta
        public int CategoryParentId { get; set; } // Id Danh Muc Cha
        public int BranchId { get; set; } // Id Chi Nhanh
        public bool Active { get; set; } // Kich Hoat
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}