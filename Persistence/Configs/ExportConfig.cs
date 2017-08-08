using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class ExportConfig
    {
        public ExportConfig(EntityTypeBuilder<Domain.Export> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}