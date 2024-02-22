using Entity_Layer.Entities.Abstarct;

namespace Entity_Layer.Entities.Concrete
{
    public class Siparis : BaseEntity<int>
    {
        public int KonutId { get; set; }
        public virtual Konut Konut { get; set; }
        public int MusteriId { get; set; }
        public virtual Musteri Musteri { get; set; }
        public virtual ICollection<SiparisDetay> SiparisDetaylar { get; set; }

    }
}
