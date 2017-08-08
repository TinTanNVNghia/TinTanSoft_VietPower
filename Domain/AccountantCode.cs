using System;

namespace Domain
{
    public class AccountantCode : IEntity
    {
        public int Id { get; set; }
        public string Code { get; set; } // Ma Danh Muc Ke Toan
        public string Name { get; set; } // Ten Danh Muc Ke Toan
        public string Description { get; set; } // Mo Ta
        public bool Active { get; set; } // Kich Hoat
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}