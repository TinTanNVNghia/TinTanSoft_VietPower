using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class HistoryConfig
    {
        public HistoryConfig(EntityTypeBuilder<Domain.History> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}