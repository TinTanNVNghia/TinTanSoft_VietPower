using System;

namespace Domain
{
    public class Language : IEntity
    {
        public int Id { get; set; }
        public string Code { get; set; } // Ma Ngon Ngu
        public string Name { get; set; } // Ten Ngon Ngu
        public bool Active { get; set; } // Kich Hoat
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}