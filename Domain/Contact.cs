using System;

namespace Domain
{
    public class Contact : IEntity
    {
        public int Id { get; set; }
        public string FullName { get; set; } // Ten Day Du Nguoi Lien He
        public int GenderId { get; set; } // Id Gioi Tinh
        public string Phone { get; set; } // So Dien Thoai
        public string PhoneBackup { get; set; } // So Dien Thoai (Co Nhieu So)
        public string Email { get; set; } // Email    
        public string Address { get; set; } // Dia Chi
        public string Description { get; set; } // Mo Ta
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}
