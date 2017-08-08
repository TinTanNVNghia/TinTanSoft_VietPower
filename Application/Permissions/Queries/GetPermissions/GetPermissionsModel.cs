using System;

namespace Application.Permissions.Queries.GetPermissions
{
    public class GetPermissionsModel
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int ConfigTableId { get; set; }
        public int ConfigColumnId { get; set; }
        public bool Read { get; set; }
        public bool Create { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
        public DateTime CreatedAt { get; set; } 
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}