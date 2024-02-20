using Cinema.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.EntityConfig
{
    public class AktorConfig : IEntityTypeConfiguration<Aktor>
    {
        public void Configure(EntityTypeBuilder<Aktor> builder)
        {
            builder.Property(p=>p.Ad).HasMaxLength(50);
        }
    }
}
