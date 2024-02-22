using Entity_Layer.Entities.Abstarct;

namespace Entity_Layer.Entities.Concrete
{

    public class Kategori : BaseEntity<int>
    {
        public string KategoriAdi { get; set; }
        public virtual ICollection<Urun> Urunler { get; set; }

    }
}
