using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class SaleConfig
    {
        public SaleConfig(EntityTypeBuilder<Domain.Sale> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}