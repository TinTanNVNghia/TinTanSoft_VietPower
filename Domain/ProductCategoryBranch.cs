using System;

namespace Domain
{
    public class ProductCategoryBranch :IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }//Id Danh Muc
        public int BranchId { get; set; }//Id Chi Nhanh
        public bool Active { get; set; } // Kich Hoat
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}