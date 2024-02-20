using Cinema.Entity.Concrete;
using Cinema.EntityConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DBContext
{
    public class SinemaSqlContext : DbContext
    {
        public DbSet<Aktor> Aktorler { get; set; }
        public DbSet<Bilet> Biletler { get; set; }
        public DbSet<Film> Filmler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Salon> Salonlar { get; set; }
        public DbSet<Seans> Seanslar { get; set; }
        public DbSet<Tarih> Tarihler { get; set; }
        public DbSet<Yonetmen> Yonetmenler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=Cinema;Trusted_Connection=True; Trust Server Certificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region I Yol
            //modelBuilder.Entity<Aktor>().Property(p => p.Ad).HasMaxLength(50); 
            #endregion

            #region II Yol
            //modelBuilder.ApplyConfiguration(new AktorConfig());
            //modelBuilder.ApplyConfiguration(new FilmConfig()); 
            #endregion

            #region * Yol
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); 
            #endregion
        }
    }

    
}
