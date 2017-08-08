using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class CustomerTypeConfig
    {
        public CustomerTypeConfig(EntityTypeBuilder<Domain.CustomerType> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}