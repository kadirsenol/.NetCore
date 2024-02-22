using Entity_Layer.Entities.Abstarct;

namespace Entity_Layer.Entities.Concrete
{
    public class SiparisDetay : BaseEntity<int>
    {
        public string ToplamTutar { get; set; }
        public int UrunId { get; set; }
        public Urun Urun { get; set; }
        public int SiparisId { get; set; }
        public Siparis Siparis { get; set; }

    }
}
