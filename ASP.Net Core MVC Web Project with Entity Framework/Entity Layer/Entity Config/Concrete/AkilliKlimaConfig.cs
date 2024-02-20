using Entity_Layer.Entities.Concrete;
using Entity_Layer.Entity_Config.Abstarct;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity_Layer.Entity_Config.Concrete
{
    public class AkilliKlimaConfig : BaseConfig<AkilliKlima, int>
    {
        public override void Configure(EntityTypeBuilder<AkilliKlima> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.EnerjiSinifi).HasMaxLength(5);
            builder.Property(p => p.Marka).HasMaxLength(20);

        }
    }
}
