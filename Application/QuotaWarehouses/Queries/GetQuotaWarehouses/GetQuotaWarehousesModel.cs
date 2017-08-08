using System;

namespace Application.QuotaWarehouses.Queries.GetQuotaWarehouses
{
    public class GetQuotaWarehousesModel
    {
        public int Id { get; set; }
        public int WarehouseId { get; set; }
        public int ProductId { get; set; }
        public Decimal QuotaQuantity { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}