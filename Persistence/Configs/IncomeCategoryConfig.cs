using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class IncomeCategoryConfig
    {
        public IncomeCategoryConfig(EntityTypeBuilder<Domain.IncomeCategory> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}