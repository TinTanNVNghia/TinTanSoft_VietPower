using System;

namespace Application.Customers.Queries.GetCustomers
{
    public class GetCustomersModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string PhoneBackup { get; set; }
        public string Gender { get; set; }
        public string CustomerType { get; set; }
        public string CustomerTypeCode { get; set; }
        public string Contact { get; set; }
        public string ContactPhone { get; set; }
        public string BankAccountName { get; set; }
        public string BankAccountNumber { get; set; }
        public string BankName { get; set; }
        public string TaxNumber { get; set; }
        public Decimal DeductionPercent { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}