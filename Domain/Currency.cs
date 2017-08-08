using System;

namespace Domain
{
    public class Currency : IEntity
    {
        public int Id { get; set; }
        public string Code { get; set; } // Ma Tien Te (Vi Du: VND -> Vietnamese Dong)
        public string Name { get; set; } // Ten Tien Te (Vi Du: Vietnamese Dong)
        public string Description { get; set; } // Mo Ta
        public bool Active { get; set; } // Kich Hoat
        public Decimal DefaultValuePerVnd { get; set; } // Gia Tri Tham Chieu Mac Dinh Voi Tien Te Vietnamese Dong 
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}
