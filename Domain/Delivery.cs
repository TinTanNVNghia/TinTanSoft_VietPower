using System;

namespace Domain
{
    public class Delivery : IEntity
    {
        public int Id { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int SaleId { get; set; }
        public int ExportId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhone { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}