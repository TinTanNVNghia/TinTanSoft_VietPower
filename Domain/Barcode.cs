using System;

namespace Domain
{
    public class Barcode : IEntity
    {
        public int Id { get; set; }
        public string Code { get; set; } // Ma Barcode
        public string Description { get; set; } // Mo Ta
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}