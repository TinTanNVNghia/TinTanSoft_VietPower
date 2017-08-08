using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class CostConfig
    {
        public CostConfig(EntityTypeBuilder<Domain.Cost> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}