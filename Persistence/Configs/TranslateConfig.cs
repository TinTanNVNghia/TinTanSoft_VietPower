using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class TranslateConfig
    {
        public TranslateConfig(EntityTypeBuilder<Domain.Translate> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}