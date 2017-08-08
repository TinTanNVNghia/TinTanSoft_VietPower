using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class CurrencyConfig
    {
        public CurrencyConfig(EntityTypeBuilder<Domain.Currency> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}