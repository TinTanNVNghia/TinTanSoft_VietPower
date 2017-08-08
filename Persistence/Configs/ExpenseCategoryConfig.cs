using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class ExpenseCategoryConfig
    {
        public ExpenseCategoryConfig(EntityTypeBuilder<Domain.ExpenseCategory> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}