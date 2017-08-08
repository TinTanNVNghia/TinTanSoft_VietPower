using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class ProductConfig
    {
        public ProductConfig(EntityTypeBuilder<Domain.Product> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}