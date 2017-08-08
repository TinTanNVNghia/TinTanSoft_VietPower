using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class LanguageConfig
    {
        public LanguageConfig(EntityTypeBuilder<Domain.Language> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}