using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class SettingConfig
    {
        public SettingConfig(EntityTypeBuilder<Domain.Setting> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}