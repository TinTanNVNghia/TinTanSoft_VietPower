using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class SupplierConfig
    {
        public SupplierConfig(EntityTypeBuilder<Domain.Supplier> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}