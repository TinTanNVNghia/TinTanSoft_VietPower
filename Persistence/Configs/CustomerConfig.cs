using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class CustomerConfig
    {
        public CustomerConfig(EntityTypeBuilder<Domain.Customer> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}