using System;

namespace Domain
{
    public class Paid : IEntity
    {
        public int Id { get; set; }
        public int SaleId { get; set; } // Id Don Hang
        public int CustomerId { get; set; } // Id Khach Hang
        public DateTime PaidDate { get; set; } // Ngay Thanh Toan
        public Decimal PaidValue { get; set; } // Tien Thanh Toan
        public string Note { get; set; } // Ghi Chu
        public int CompanyId { get; set; } // Id Cong Ty
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}