namespace HastaneRandevu
{
    public class Randevu
    {
        public int Id { get; set; }
        public Hasta Hasta { get; set; }
        public Doktor Doktor { get; set; }
        public Poliklinik Poliklinik { get; set; }
        public DateTime Tarih { get; set; }

    }
}
