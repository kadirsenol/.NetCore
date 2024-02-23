using Microsoft.EntityFrameworkCore;

namespace CodeFirst_of_Entity_Framework
{
    public class SqlDbContext : DbContext
    {
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=.;Database=Kirtasiye;Trusted_Connection=true;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kitap>().Property(p => p.KitapAdi).HasMaxLength(50);
            modelBuilder.Entity<Yazar>().Property(p => p.TcNo).HasMaxLength(11);
        }
    }
}
