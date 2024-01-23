namespace MyKrediKarti.KartBilesenleri
{
    public class KartSahibi
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Yas { get; set; }
        private string _TcNo;

        public string TcNo
        {
            get 
            {
             return _TcNo.Substring(8); 
            }
            set 
            {
                if (value.Length == 11)
                {
                    _TcNo = value;
                }
                else
                {
                    Console.WriteLine("Eksik veya Hatali Kimlik Numarasi Girdiniz..");
                }
              
            }
        }

    }
}