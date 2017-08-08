using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class ProductCategoryBranchConfig
    {
        public ProductCategoryBranchConfig(EntityTypeBuilder<Domain.ProductCategoryBranch> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}