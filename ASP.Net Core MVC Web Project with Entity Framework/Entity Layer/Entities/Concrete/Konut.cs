using Entity_Layer.Entities.Abstarct;

namespace Entity_Layer.Entities.Concrete
{
    public enum KonutType : byte  // Fikir olması açısından
    {
        mustakil = 0,
        apartmandaire,
        kirevi,
        bagevi,
        teras
    }

    public class Konut : BaseEntity<int>
    {
        public KonutType KonutTip { get; set; }
        public virtual ICollection<Siparis> Siparisler { get; set; }

    }
}
