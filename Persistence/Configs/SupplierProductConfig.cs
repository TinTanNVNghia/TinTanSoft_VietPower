using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class SupplierProductConfig
    {
        public SupplierProductConfig(EntityTypeBuilder<Domain.SupplierProduct> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}