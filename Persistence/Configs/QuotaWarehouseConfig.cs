using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class QuotaWarehouseConfig
    {
        public QuotaWarehouseConfig(EntityTypeBuilder<Domain.QuotaWarehouse> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}