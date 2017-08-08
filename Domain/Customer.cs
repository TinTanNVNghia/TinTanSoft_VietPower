using System;

namespace Domain
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string Code { get; set; } // Ma Khach Hang
        public string Name { get; set; } // Ten Khach Hang
        public string Address { get; set; } // Dia Chi
        public string Email { get; set; } // Email
        public string Phone { get; set; } // So Dien Thoai
        public string PhoneBackup { get; set; } // So Dien Thoai (Neu Co Nhieu So)
        public int GenderId { get; set; } // Id Gioi Tinh
        public int CustomerTypeId { get; set; } // Id Nhom Khach Hang
        public int ContactId { get; set; } // Id Nguoi Lien He
        public int CompanyId { get; set; } // Id Cong Ty
        public string BankAccountName { get; set; } // Ten Tai Khoan Ngan Hang Khach Hang
        public string BankAccountNumber { get; set; } // So Tai Khoan Ngan Khach Hang
        public string BankName { get; set; } // Ten Ngan Hang Mo Tai Khoan Khach Hang
        public string TaxNumber { get; set; } // Ma So Thue Khach Hang
        public Decimal DeductionPercent { get; set; } // Phan Tram Chiet Khau
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}