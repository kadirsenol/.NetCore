using Entity_Layer.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Data_Access_Layer.DBContexts
{
    public class SqlDbContext : DbContext
    {

        public DbSet<AkilliKlima> AkilliKlimalar { get; set; }
        public DbSet<AkilliPerde> AkilliPerdeler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=IoTAutomations;Trusted_Connection=True; Trust Server Certificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.Load("Entity Layer"));
        }
    }
}
