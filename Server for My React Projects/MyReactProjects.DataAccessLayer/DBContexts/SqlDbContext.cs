using MeetingOrganizer.EntityLayer.Abstract;
using MeetingOrganizer.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace MeetingOrganizer.DataAccessLayer.DBContexts
{
    public class SqlDbContext : DbContext
    {
        public DbSet<ToplantiKayit> ToplantiKayitlar { get; set; }
        public DbSet<Product> Urunler { get; set; }
        public DbSet<User> Kullanıcılar { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.Load("MeetingOrganizer.EntityLayer"));
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=ReactProjects;Trusted_Connection=True; Trust Server Certificate=true; MultipleActiveResultSets=True");
        }

        // Soft delete olarak calistigimiz veritabanimizda delete islemi gerceklestiginde changetracker kayıt olan deleted islemlerini
        // savechange metodunu ezerek durumun bir delete degil update oldugunu belirtip update olacak propları tanimliyoruz.
        // artik butun delete islemleri bir update olarak algilanacak ve sadece isdelete ile updatedate fieldleri degisecek. 
        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {

            var changes = ChangeTracker.Entries().Where(p => p.State == EntityState.Deleted).ToList();

            foreach (var item in changes)
            {
                item.State = EntityState.Modified;
                BaseEntity<int> baseEntity = item.Entity as BaseEntity<int>;
                baseEntity.IsDelete = true;
                baseEntity.UpdateDate = DateTime.UtcNow.AddHours(3);
            }

            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
    }
}
