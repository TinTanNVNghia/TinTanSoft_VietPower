using System;

namespace Domain
{
    public class Department : IEntity
    {
        public int Id { get; set; }
        public int BranchId { get; set; } // Id Chi Nhanh
        public string Code { get; set; } // Ma Phong Ban
        public string Name { get; set; } // Ten Phong Ban
        public string Description { get; set; } // Mo Ta
        public int DepartmentAccountId { get; set; } // Id Nguoi Quan Ly Phong Ban (Lien Ket Den Bang Tai Khoan)
        public bool Active { get; set; } // Kich Hoat
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}