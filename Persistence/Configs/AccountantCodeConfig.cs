using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class AccountantCodeConfig
    {
        public AccountantCodeConfig(EntityTypeBuilder<Domain.AccountantCode> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}