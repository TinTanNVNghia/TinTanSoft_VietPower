using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class ExpenseConfig
    {
        public ExpenseConfig(EntityTypeBuilder<Domain.Expense> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}