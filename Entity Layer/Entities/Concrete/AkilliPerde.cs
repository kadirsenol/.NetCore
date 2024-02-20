using Entity_Layer.Entities.Abstarct;

namespace Entity_Layer.Entities.Concrete
{
    public class AkilliPerde : BaseEntity<int>
    {
        public string Marka { get; set; }
        public string En { get; set; }
        public string Boy { get; set; }
        public string KaplamaMaddesi { get; set; }
        public string Fiyat { get; set; }
        public virtual ICollection<Konut> Konutlar { get; set; }
    }
}
