using System;

namespace Domain
{
    public class Cost : IEntity
    {
        public int Id { get; set; }
        public string Code { get; set; } // Ma Chi Phi
        public string Name { get; set; } // Ten Chi Phi
        public string Description { get; set; } // Mo Ta
        public bool Active { get; set; } // Kich Hoat
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}