using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class UnitConfig
    {
        public UnitConfig(EntityTypeBuilder<Domain.Unit> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}