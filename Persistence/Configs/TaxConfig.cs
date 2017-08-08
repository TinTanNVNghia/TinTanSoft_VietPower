using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class TaxConfig
    {
        public TaxConfig(EntityTypeBuilder<Domain.Tax> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}