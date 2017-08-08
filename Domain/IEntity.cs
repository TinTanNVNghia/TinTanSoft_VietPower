using System;

namespace Domain
{
    public interface IEntity
    {
        int Id { get; set; }
        DateTime CreatedAt { get; set; } // Ngay Tao
        DateTime UpdatedAt { get; set; } // Ngay Cap Nhat
        int CreatedBy { get; set; } // Nguoi Tao
        int UpdatedBy { get; set; } // Nguoi Cap Nhat
    }
}