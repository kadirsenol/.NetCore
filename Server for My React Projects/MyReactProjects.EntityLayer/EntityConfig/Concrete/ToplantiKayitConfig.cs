using MeetingOrganizer.EntityLayer.Concrete;
using MeetingOrganizer.EntityLayer.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MeetingOrganizer.EntityLayer.EntityConfig.Concrete
{
    public class ToplantiKayitConfig : BaseEntityConfig<ToplantiKayit, int>
    {
        public override void Configure(EntityTypeBuilder<ToplantiKayit> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Konu).HasMaxLength(50);
            builder.Property(p => p.Katilimcilar).HasMaxLength(500);
            builder.Property(p => p.BitisSaati).IsRequired(true);
            builder.Property(p => p.BaslamaSaati).IsRequired(true);
            builder.Property(p => p.Tarih).IsRequired(true);
        }
    }
}
