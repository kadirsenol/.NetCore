using MyKrediKarti.KrediKarti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKrediKarti.KartBilesenleri
{
    public class KartBilgileri
    {
        public KartSahibi kartsahibi { get; set; }
        private string _cvv { get; set; }
        public string cvv 
        {
            get
            {
                return "***";
            }

            set
            {
                if (value.Length == 3)
                {
                    _cvv = value;
                }
                else
                {
                    Console.WriteLine("Hatali Cvv Girisi..");
                }
                
            }
        }
        private string _skt;

        public string skt
        {
            get
            {
                return $"{_skt.Substring(0,2)}-**-***{_skt.Substring(8)}"; 
            }
            set 
            {
                _skt = value; 
            }
        }
        private string _kartno;

        public string kartno
        {
            get
            {
                if (_kartno.Length == 16)
                {
                    return $"****-****-****-{_kartno.Substring(12)}";
                }
                else
                {
                    Console.WriteLine("Hatali Veya Eksik Kart No..");
                    return "";  
                }
            }
            set 
            {
                if (value.Length == 16 && double.TryParse(value,out double a) && (!String.IsNullOrEmpty(value))) 
                {
                    _kartno = value;

                    kartbilgilerinibul();
                    if (kartdetay.bankaadi == null || kartdetay.karttipi == null || kartdetay.subtipi == null)
                    {
                        Console.WriteLine("Kart Bilgilerine Ulaşılamadı..");

                    }
                    else
                    {
                       Console.WriteLine($"Banka Bilgisi:{kartdetay.bankaadi}" +
                                         $"\nKar Tipi:{kartdetay.karttipi}" +
                                         $"\nSub Tipi:{kartdetay.subtipi}" +
                                         $"\nKart No:{kartno}");
                    }
              
                }
                else
                {
                    _kartno="";
                    Console.WriteLine(kartno);
                }
            }
        }

        public Kartdetay kartdetaybilgileri { get; private set; }
        Kartdetay kartdetay = new Kartdetay();

        public void kartbilgilerinibul()
        {
            var satirlar = File.ReadAllLines("KrediKart.txt");
            for (int i = 1; i < satirlar.Length; i++)
            {
                var satir = satirlar[i].Split(',');
                if (satir[0] == _kartno.Substring(0,6))
                {
                    
                    kartdetay.bankaadi = satir[2];
                    kartdetay.karttipi = satir[3];
                    kartdetay.subtipi = satir[4];
                    break;
                }
         
            }

        }


    }
}
