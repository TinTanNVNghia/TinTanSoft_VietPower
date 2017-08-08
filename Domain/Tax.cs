using System;

namespace Domain
{
    public class Tax : IEntity
    {
        public int Id { get; set; }
        public string Code { get; set; } // Ma Thue (Vi Du: VAT -> Thue Gia Tri Gia Tang)
        public string Name { get; set; } // Ten Loai Thue (Vi Du: Thue Gia Tri Gia Tang)
        public string Description { get; set; } // Mo Ta
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}