using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class OrderSupplierDetailConfig
    {
        public OrderSupplierDetailConfig(EntityTypeBuilder<Domain.OrderSupplierDetail> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}