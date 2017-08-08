using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class WarehouseConfig
    {
        public WarehouseConfig(EntityTypeBuilder<Domain.Warehouse> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}