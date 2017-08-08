using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configs
{
    public class BarcodeConfig
    {
        public BarcodeConfig(EntityTypeBuilder<Domain.Barcode> entity)
        {
            entity.HasKey(p => p.Id);
        }
    }
}