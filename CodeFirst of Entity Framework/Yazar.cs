namespace CodeFirst_of_Entity_Framework
{
    public class Yazar
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int Yas { get; set; }
        public string TcNo { get; set; }
        public virtual ICollection<Kitap> Kitaplar { get; set; }
    }
}