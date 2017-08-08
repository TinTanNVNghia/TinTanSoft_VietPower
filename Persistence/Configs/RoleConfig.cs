using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class RoleConfig
    {
        public RoleConfig(EntityTypeBuilder<Domain.Role> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}