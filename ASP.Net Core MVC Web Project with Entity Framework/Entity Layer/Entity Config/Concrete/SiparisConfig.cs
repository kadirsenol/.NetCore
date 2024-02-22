using Entity_Layer.Entities.Concrete;
using Entity_Layer.Entity_Config.Abstarct;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity_Layer.Entity_Config.Concrete
{
    public class SiparisConfig : BaseConfig<Siparis, int>
    {
        public override void Configure(EntityTypeBuilder<Siparis> builder)
        {
            base.Configure(builder);
        }
    }
}
