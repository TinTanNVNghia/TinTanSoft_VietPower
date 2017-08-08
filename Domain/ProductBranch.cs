using System;

namespace Domain
{
    public class ProductBranch:IEntity
    {
        public int Id { get; set; }
        public int CategoryBranchId { get; set; }//Id Danh Muc Chi Nhanh
        public int ProductId { get; set; }//Id San Pham
        public bool Active { get; set; } // Kich Hoat
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}