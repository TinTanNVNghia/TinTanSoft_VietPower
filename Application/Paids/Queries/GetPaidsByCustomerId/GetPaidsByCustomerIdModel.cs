using System;

namespace Application.Paids.Queries.GetPaidsByCustomerId
{
    public class GetPaidsByCustomerIdModel
    {
        public int Id { get; set; }
        public string SaleCode { get; set; }
        public DateTime SaleDate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerCode { get; set; }
        public DateTime PaidDate { get; set; }
        public Decimal PaidValue { get; set; }
        public string Note { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}