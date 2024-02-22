using Entity_Layer.Entities.Concrete;
using Entity_Layer.Entity_Config.Abstarct;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity_Layer.Entity_Config.Concrete
{
    public class KategoriConfig : BaseConfig<Kategori, int>
    {
        public override void Configure(EntityTypeBuilder<Kategori> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.KategoriAdi).HasMaxLength(50);
        }
    }
}
