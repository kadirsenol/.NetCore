using Entity_Layer.Entities.Abstarct;

namespace Entity_Layer.Entities.Concrete
{
    public class AkilliKlima : BaseEntity<int>
    {
        public string Marka { get; set; }
        public string EnerjiSinifi { get; set; }
        public string Fiyat { get; set; }
        public virtual ICollection<Konut> Konutlar { get; set; }

    }
}
