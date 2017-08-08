using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class ContactConfig
    {
        public ContactConfig(EntityTypeBuilder<Domain.Contact> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}