using System;

namespace Application.Sales.Queries.GetSales
{
    public class GetSalesModel
    {
        public int Id { get; set; }
        public string Code { get; set; } // Ma Don Hang
        public int CustomerId { get; set; } // Id Khach Hang
        public DateTime SaleDate { get; set; } // Ngay Ban Hang
        public Decimal Total { get; set; } // Tong Tien Tu Chi Tiet Ban Hang
        public Decimal TaxValue { get; set; } // Tien Thue
        public Decimal CostValue { get; set; } // Tien Phi
        public Decimal Discount { get; set; } // Giam Gia
        public Decimal Paid { get; set; } // So Tien Khach Hang Thanh Toan
        public string Note { get; set; } // Ghi Chu Ban Hang
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}