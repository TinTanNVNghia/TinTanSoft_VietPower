using System;

namespace Domain
{
    public class Warehouse : IEntity
    {
        public int Id { get; set; }
        public string Code { get; set; } // Ma Kho
        public string Name { get; set; } // Ten Kho
        public int BranchId { get; set; } // Id Chi Nhanh
        public int WarehouseAccountId { get; set; } // Id Nguoi Quan Ly
        public string Address { get; set; } // Dia Chi Kho
        public bool Active { get; set; } // Kich Hoat
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}