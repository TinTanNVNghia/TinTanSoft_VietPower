using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class PermissionConfig
    {
        public PermissionConfig(EntityTypeBuilder<Domain.Permission> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}