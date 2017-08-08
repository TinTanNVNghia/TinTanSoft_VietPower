using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class CompanyConfig
    {
        public CompanyConfig(EntityTypeBuilder<Domain.Company> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}