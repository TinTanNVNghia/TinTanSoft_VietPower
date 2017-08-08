using System;

namespace Domain
{
    public class Income : IEntity
    {
        public int Id { get; set; }
        public DateTime IncomeDate { get; set; } // Ngay Thu
        public int IncomeAccountId { get; set; } // Id Nguoi Tao Phieu Thu
        public int IncomeCategoryId { get; set; } // Id Danh Muc Thu
        public int BranchId { get; set; } // Id Chi Nhanh
        public Decimal Value { get; set; } // Gia Tri Tien Thu
        public int CurrencyId { get; set; } // Id Tien Te
        public string Note { get; set; } // Ghi Chu
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}