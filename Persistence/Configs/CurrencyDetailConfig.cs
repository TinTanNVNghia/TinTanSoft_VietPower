using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class CurrencyDetailConfig
    {
        public CurrencyDetailConfig(EntityTypeBuilder<Domain.CurrencyDetail> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}