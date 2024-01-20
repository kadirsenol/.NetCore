namespace HastaneRandevu
{
    public class Hasta
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string? TcNo { get; set; }
        public string Email { get; set; }

        // Yapici Metodlar Nesne ilk olurturulurken (instance alinirken) 
        // Calisan metodlardir
        // Diger metodlar farkli olarak geri donus degeri yoktur
        // Yapici (Constructer) metodlar mutlaka Class ismi ile ayni olmak zorundadir
        // Bir Class icerisinde birden fazla constructer bulunabilir. Ancak aldigi parametreler farkli olmazk zorundadir. Bu kural normöal metodlar icin gecerli oldugundan burada da gecerlidir.


        public Hasta(int id, string ad, string soyad, string tcno)
        {
            Id = id;
            Ad = ad;
            Soyad = soyad;
            TcNo = tcno;
        }
        // Sinifin Yikici Metodu
        ~Hasta()
        {
            Console.WriteLine("Yikici Metod Calisti");

        }

    }
}
