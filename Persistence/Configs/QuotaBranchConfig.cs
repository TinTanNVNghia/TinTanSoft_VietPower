using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class QuotaBranchConfig
    {
        public QuotaBranchConfig(EntityTypeBuilder<Domain.QuotaBranch> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}