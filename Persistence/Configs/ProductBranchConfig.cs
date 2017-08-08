using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class ProductBranchConfig
    {
        public ProductBranchConfig(EntityTypeBuilder<Domain.ProductBranch> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}