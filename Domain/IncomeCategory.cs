using System;

namespace Domain
{
    public class IncomeCategory : IEntity
    {
        public int Id { get; set; }
        public string Code { get; set; } // Ma Danh Muc Thu
        public string Name { get; set; } // Ten Danh Muc Thu
        public string Description { get; set; } // Mo Ta
        public bool Active { get; set; } // Kich Hoat
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}