using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class PositionConfig
    {
        public PositionConfig(EntityTypeBuilder<Domain.Position> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}