using System;

namespace Domain
{
    public class Company : IEntity
    {
        public int Id { get; set; }
        public string Code { get; set; } // Ma Cong Ty
        public string Name { get; set; } // Ten Cong Ty
        public string Address { get; set; } // Dia Chi
        public string Phone { get; set; } // So Dien Thoai
        public string PhoneBackup { get; set; } // So Dien Thoai (Neu Co Nhieu So)
        public string TaxNumber { get; set; } // Ma So Thue Cong Ty
        public int CompanyAccountId { get; set; } // Id Nguoi Quan Ly Cong Ty(Lien Ket Den Bang Tai Khoan)
        public string BankAccountName { get; set; } // Ten Tai Khoan Ngan Hang Cong Ty
        public string BankAccountNumber { get; set; } // So Tai Khoan Ngan Cong Ty
        public string BankName { get; set; } // Ten Ngan Hang Mo Tai Khoan Cong Ty
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}