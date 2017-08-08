using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class BranchConfig
    {
        public BranchConfig(EntityTypeBuilder<Domain.Branch> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}