using System;

namespace Domain
{
    public class Unit : IEntity
    {
        public int Id { get; set; }
        public string Code { get; set; } // Ma Don Vi (Vi Du: m -> Met) 
        public string Description { get; set; } // Mo Ta
        public bool Active { get; set; } // Kich Hoat
        public int RelateUnitId { get; set; } // Id Don Vi Tham Chieu (Vi Du: m -> cm)
        public Decimal RelateUnitValue { get; set; } // Gia Tri Tham Chieu (Vi Du: 1m -> 100cm)
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}