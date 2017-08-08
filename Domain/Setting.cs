using System;

namespace Domain
{
    public class Setting : IEntity
    {
        public int Id { get; set; }
        public string Key { get; set; } // Khoa Tham Chieu
        public string Value { get; set; } // Gia Tri
        public string Type { get; set; } // Kieu Du Lieu
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}