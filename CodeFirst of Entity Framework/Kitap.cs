namespace CodeFirst_of_Entity_Framework
{
    public class Kitap
    {
        public int Id { get; set; }
        public string KitapAdi { get; set; }
        public string YayinEvi { get; set; }
        public int SayfaSayisi { get; set; }
        public int YazarId { get; set; }
        public Yazar Yazar { get; set; }
    }
}
