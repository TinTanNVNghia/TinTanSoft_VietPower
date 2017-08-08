using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class ImportDetailConfig
    {
        public ImportDetailConfig(EntityTypeBuilder<Domain.ImportDetail> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}