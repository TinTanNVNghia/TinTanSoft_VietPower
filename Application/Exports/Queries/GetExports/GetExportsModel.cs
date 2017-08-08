using System;

namespace Application.Exports.Queries.GetExports
{
    public class GetExportsModel
    {
        public int Id { get; set; }
        public DateTime ExportDate { get; set; }
        public string Note { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}