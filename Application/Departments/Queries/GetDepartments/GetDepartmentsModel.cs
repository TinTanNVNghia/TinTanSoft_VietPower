using System;

namespace Application.Departments.Queries.GetDepartments
{
    public class GetDepartmentsModel
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DepartmentAccountId { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}