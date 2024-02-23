using Microsoft.EntityFrameworkCore;

namespace Table_Per_Type_TPT__for_Entity_Framework
{
    public class SqlDbContext : DbContext
    {
        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=.;Database=Okul;Trusted_Connection=true;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Table Per Type(TPT)
            //Fluent Api ToTable kodu ile ilgili classlar db de ayrı bir tablo olarak tutulur.
            modelBuilder.Entity<Student>().ToTable("StudentUsers");
            modelBuilder.Entity<Teacher>().ToTable("TeacherUsers");
        }
    }
}
