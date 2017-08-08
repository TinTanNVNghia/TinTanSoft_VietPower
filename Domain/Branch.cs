using System;

namespace Domain
{
    public class Branch : IEntity
    {
        public int Id { get; set; }
        public string Code { get; set; } // Ma Chi Nhanh
        public string Name { get; set; } // Ten Chi Nhanh
        public string Address { get; set; } // Dia Chi Chi Nhanh
        public string Phone { get; set; } // So Dien Thoai
        public string PhoneBackup { get; set; } // So Dien Thoai (Neu Co Nhieu So) 
        public string TaxNumber { get; set; } // Ma So Thue Chi Nhanh
        public string BankAccountName { get; set; } // Ten Tai Khoan Ngan Hang Chi Nhanh
        public string BankAccountNumber { get; set; } // So Tai Khoan Ngan Chi Nhanh
        public string BankName { get; set; } // Ten Ngan Hang Mo Tai Khoan Chi Nhanh
        public string Description { get; set; } // Mo Ta
        public bool Active { get; set; } // Kich Hoat
        public int BranchAccountId { get; set; } // Id Nguoi Quan Ly Chi Nhanh(Lien Ket Den Bang Tai Khoan)
        public int BranchParentId { get; set; } // Id Chi Nhanh Cha
        public DateTime CreatedAt { get; set; } 
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}