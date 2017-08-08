using System;

namespace Domain
{
    public class Role : IEntity
    {
        public int Id { get; set; }
        public string Code { get; set; } // Ma Nhom Quyen
        public string Name { get; set; } // Ten Nhom Quyen
        public string Description { get; set; } // Mo Ta
        public bool Active { get; set; } // Kich Hoat
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}