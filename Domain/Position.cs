using System;

namespace Domain
{
    public class Position : IEntity
    {
        public int Id { get; set; }
        public int BranchId { get; set; } // Id Chi Nhanh
        public string Code { get; set; } // Ma Chuc Vu
        public string Name { get; set; } // Ten Chuc Vu
        public string Description { get; set; } // Mo Ta
        public bool Active { get; set; } // Kich Hoat 
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}
