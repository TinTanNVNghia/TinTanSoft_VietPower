using System;

namespace Application.Units.Queries.GetUnits
{
    public class GetUnitsModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public int RelateUnitId { get; set; }
        public Decimal RelateUnitValue { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}