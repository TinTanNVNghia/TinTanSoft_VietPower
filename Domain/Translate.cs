using System;

namespace Domain
{
    public class Translate : IEntity
    {
        public int Id { get; set; }
        public string Field { get; set; } // Truong Du Lieu
        public string Value { get; set; } // Gia Tri Chuyen Doi Ngon Ngu
        public string Group { get; set; } // Nhom Chuyen Doi (Vi Du: Table_Name,Column_Name,Menu,Notify,...)
        public int LanguageId { get; set; } // Id Ngon Ngu
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}