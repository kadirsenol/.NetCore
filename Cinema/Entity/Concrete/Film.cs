using Cinema.Entity.Abstract;

namespace Cinema.Entity.Concrete
{
    public class Film : BaseEntity
    {
        public string FilmAdi { get; set; }
        public int Sure { get; set; }
        public virtual ICollection<Kategori> Kategoriler { get; set; } = new List<Kategori>();

        public virtual ICollection<Yonetmen> Yonetmenler { get; set; } = new List<Yonetmen>();
        public virtual ICollection<Aktor> Aktorler { get; set; } = new List<Aktor>();
        public virtual ICollection<Bilet> Biletler { get; set; } = new List<Bilet>();

    }
}