using Cinema.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DBContext
{
    public class SinemaNpgSqlContext : DbContext
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
            optionsBuilder.UseNpgsql(@"Server=localhost;Database=Cinema;User Id=postgres;password=6196");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
