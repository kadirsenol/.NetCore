using Entity_Layer.Entities.Concrete;
using Entity_Layer.Entity_Config.Abstarct;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity_Layer.Entity_Config.Concrete
{
    public class AkilliPerdeConfig : BaseConfig<AkilliPerde, int>
    {
        public override void Configure(EntityTypeBuilder<AkilliPerde> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.KaplamaMaddesi).HasMaxLength(50);
            builder.Property(p => p.Boy).HasMaxLength(100);
            builder.Property(p => p.En).HasMaxLength(100);
            builder.Property(p => p.Marka).HasMaxLength(50);
        }
    }
}
