using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class GenderConfig
    {
        public GenderConfig(EntityTypeBuilder<Domain.Gender> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}