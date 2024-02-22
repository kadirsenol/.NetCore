using Entity_Layer.Entities.Abstarct;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity_Layer.Entity_Config.Abstarct
{
    public abstract class BaseConfig<T, TId> : IEntityTypeConfiguration<T> where T : BaseEntity<TId>
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(p => p.Code).HasMaxLength(50);
        }
    }
}
