using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class IncomeConfig
    {
        public IncomeConfig(EntityTypeBuilder<Domain.Income> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}