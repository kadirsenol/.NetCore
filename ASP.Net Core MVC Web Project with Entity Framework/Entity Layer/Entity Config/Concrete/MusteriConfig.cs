using Entity_Layer.Entities.Concrete;
using Entity_Layer.Entity_Config.Abstarct;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity_Layer.Entity_Config.Concrete
{
    public class MusteriConfig : BaseConfig<Musteri, int>
    {
        public override void Configure(EntityTypeBuilder<Musteri> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Adi).HasMaxLength(50);
            builder.Property(p => p.Adres).HasMaxLength(500);
            builder.Property(p => p.Soyadi).HasMaxLength(50);
            builder.Property(p => p.Email).HasMaxLength(50);
            builder.Property(p => p.Password).HasMaxLength(50);
            builder.Property(p => p.TcNo).HasMaxLength(11);
        }
    }
}
