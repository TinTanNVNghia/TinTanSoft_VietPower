using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class DepartmentConfig
    {
        public DepartmentConfig(EntityTypeBuilder<Domain.Department> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}