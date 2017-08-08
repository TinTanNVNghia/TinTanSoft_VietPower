using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class SaleDetailConfig
    {
        public SaleDetailConfig(EntityTypeBuilder<Domain.SaleDetail> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}