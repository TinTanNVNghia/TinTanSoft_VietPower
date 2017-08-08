using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class AccountConfig
    {
        public AccountConfig(EntityTypeBuilder<Domain.Account> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}