using Cinema.Entity.Abstract;

namespace Cinema.Entity.Concrete
{
    public class Kategori : BaseEntity
    {
        public string KategoriName { get; set; }

        public List<Film> Filmler { get; set; }
    }
}