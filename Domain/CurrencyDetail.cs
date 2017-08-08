using System;

namespace Domain
{
    public class CurrencyDetail : IEntity
    {
        public int Id { get; set; }
        public int CurrencyId { get; set; } // Id Tien Te
        public Decimal ValuePerVnd { get; set; } // Gia Tri Tham Chieu Voi Tien Te Vietnamese Dong
        public DateTime ApplyDate { get; set; } // Thoi Diem Ap Dung
        public string ModifyNote { get; set; } // Ghi Chu Thay Doi Ti gia
        public bool Active { get; set; } // Kich Hoat
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}