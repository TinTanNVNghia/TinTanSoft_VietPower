using System;

namespace Domain
{
    public class Expense : IEntity
    {
        public int Id { get; set; }
        public DateTime ExpenseDate { get; set; } // Ngay Chi
        public int ExpenseAccountId { get; set; } // Id Nguoi Tao Phieu Chi
        public int ExpenseCategoryId { get; set; } // Id Danh Muc Chi
        public int BranchId { get; set; } // Id Chi Nhanh
        public Decimal Value { get; set; } // Gia Tri Tien Chi
        public int CurrencyId { get; set; } // Id Tien Te
        public string Note { get; set; } // Ghi Chu
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}