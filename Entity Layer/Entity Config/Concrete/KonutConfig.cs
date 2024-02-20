using Entity_Layer.Entities.Concrete;
using Entity_Layer.Entity_Config.Abstarct;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity_Layer.Entity_Config.Concrete
{
    public class KonutConfig : BaseConfig<Konut, int>
    {
        public override void Configure(EntityTypeBuilder<Konut> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.KonutTip).HasMaxLength(3);
        }
    }
}
