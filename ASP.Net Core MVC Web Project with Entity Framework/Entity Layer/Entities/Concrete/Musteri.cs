using Entity_Layer.Entities.Abstarct;

namespace Entity_Layer.Entities.Concrete
{
    public class Musteri : BaseEntity<int>
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string TcNo { get; set; }
        public string Adres { get; set; }
        public virtual ICollection<Siparis> Siparisler { get; set; }

    }
}
