using System;

namespace Domain
{
    public class Supplier : IEntity
    {
        public int Id { get; set; }
        public string Code { get; set; } // Ma Nha Cung Cap
        public string Name { get; set; } // Ten Nha Cung Cap
        public string Address { get; set; } // Dia Chi
        public string Phone { get; set; } // So Dien Thoai
        public string Note { get; set; } // Ghi Chu
        public string BankAccountName { get; set; } // Ten Tai Khoan Ngan Hang Nha Cung Cap
        public string BankAccountNumber { get; set; } // So Tai Khoan Ngan Nha Cung Cap
        public string BankName { get; set; } // Ten Ngan Hang Mo Tai Khoan Nha Cung Cap
        public string TaxNumber { get; set; } // Ma So Thue Nha Cung Cap
        public int ContactId { get; set; } // Id Nguoi Lien He
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}