using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class ImportConfig
    {
        public ImportConfig(EntityTypeBuilder<Domain.Import> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}