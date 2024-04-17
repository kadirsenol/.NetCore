using MeetingOrganizer.EntityLayer.Concrete;
using MeetingOrganizer.EntityLayer.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MeetingOrganizer.EntityLayer.EntityConfig.Concrete
{
    public class UserConfig : BaseEntityConfig<User, int>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Ad).HasMaxLength(50);
            builder.Property(p => p.Email).HasMaxLength(50);
            builder.Property(p => p.Password).HasMaxLength(50);
            builder.Property(p => p.TcNo).HasMaxLength(11);
            builder.Property(p => p.Rol).HasMaxLength(15);
            builder.HasIndex(p => p.Email).IsUnique();
        }
    }
}
