using MeetingOrganizer.EntityLayer.Concrete;
using MeetingOrganizer.EntityLayer.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MeetingOrganizer.EntityLayer.EntityConfig.Concrete
{
    public class ProductConfig : BaseEntityConfig<Product, int>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Name).HasMaxLength(50);
            builder.Property(p => p.Price).HasMaxLength(50);
        }
    }
}
