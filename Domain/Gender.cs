using System;

namespace Domain
{
    public class Gender : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } // Ten Gioi Tinh
        public bool Active { get; set; } // Kich Hoat
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}
