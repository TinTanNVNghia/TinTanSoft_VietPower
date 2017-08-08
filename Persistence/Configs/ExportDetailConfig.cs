using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class ExportDetailConfig
    {
        public ExportDetailConfig(EntityTypeBuilder<Domain.ExportDetail> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}