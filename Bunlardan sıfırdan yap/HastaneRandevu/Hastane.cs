namespace HastaneRandevu
{
    public class Hastane
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public List<Poliklinik>? Poliklinikler { get; set; } = new List<Poliklinik>();

        public List<Doktor>? Doktorlar { get; set; } = new List<Doktor>();

    }
}
