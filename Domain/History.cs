using System;

namespace Domain
{
    public class History : IEntity
    {
        public int Id { get; set; }
        public string TableName { get; set; } // Ten Bang
        public int RowId { get; set; } // Id Dong Du Lieu Tren Bang
        public string Column { get; set; } // Ten Cot Du Lieu
        public string OldValue { get; set; } // Gia Tri Cu
        public string NewValue { get; set; } // Gia Tri Moi
        public string ColumnType { get; set; } // Kieu Du Lieu
        public bool Delete { get; set; } // Xoa Du Lieu
        public int AccountId { get; set; } // Id Nguoi Thao Tac
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}