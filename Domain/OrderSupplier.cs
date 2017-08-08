using System;

namespace Domain
{
    public class OrderSupplier : IEntity
    {
        public int Id { get; set; }
        public string Code { get; set; } // Ma Don Dat Hang
        public DateTime OrderDate { get; set; } // Ngay Dat Hang
        public int OrderAccountId { get; set; } // Id Nguoi Dat Hang
        public bool OrderFromOneSupplier { get; set; } // Chi Dat Hang Tu Mot Nha Cung Cap
        public Decimal TotalDefault { get; set; } // Tong Tien Don Dat Hang Tinh Tu Dat Hang Chi Tiet
        public Decimal OrtherPlus { get; set; } // Tong Tien Them Vao
        public Decimal OrtherMinus { get; set; } // Tong Tien Tru Di
        public Decimal TotalAfter { get; set; } // Tong Tien Dat Hang Cuoi Cung
        public string Note { get; set; } // Ghi Chu
        public DateTime CreatedAt { get; set; } 
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}
