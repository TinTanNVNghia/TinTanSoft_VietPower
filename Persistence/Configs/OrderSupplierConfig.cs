using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class OrderSupplierConfig
    {
        public OrderSupplierConfig(EntityTypeBuilder<Domain.OrderSupplier> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}