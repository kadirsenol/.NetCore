using Entity_Layer.Entities.Abstarct;

namespace Entity_Layer.Entities.Concrete
{
    public class Urun : BaseEntity<int>
    {
        public string UrunAdi { get; set; }
        public string Fiyat { get; set; }
        public string StokAdet { get; set; }
        public int KategoriId { get; set; }
        public virtual Kategori Kategori { get; set; }

        public virtual ICollection<SiparisDetay> SiparisDetaylar { get; set; }

    }
}
