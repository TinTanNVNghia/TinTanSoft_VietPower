using System;

namespace Application.Imports.Queries.GetImports
{
    public class GetImportsModel
    {
        public int Id { get; set; }
        public DateTime ImportDate { get; set; }
        public string Note { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}