using System;

namespace Domain
{
    public class Account : IEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; } // Ten Dang Nhap
        public string FullName { get; set; } // Ten Day Du
        public string Email { get; set; } // Email 
        public string Password { get; set; } // Mat Khau
        public string Phone { get; set; } // So Dien Thoai
        public string PhoneBackup { get; set; } // So Dien Thoai (Co Nhieu So) 
        public int Age { get; set; } // Tuoi
        public DateTime DayOfBirth { get; set; } // Ngay Sinh
        public string GovernmentId { get; set; } // So Chung Minh Nhan Dan
        public string Address { get; set; } // Dia Chi
        public bool Active { get; set; } // Kich Hoat
        public string Note { get; set; } // Ghi Chu
        public int GenderId { get; set; } // Ma Gioi Tinh
        public int DepartmentId { get; set; } // Ma Phong Ban
        public int PositionId { get; set; } // Id Chuc Vu
        public int BranchId { get; set; } // Id Chi Nhanh ( se giong voi id Cong ty neu la tai khoan admin cua cong ty)
        public int CompanyId { get; set; }// Id Cong ty
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}