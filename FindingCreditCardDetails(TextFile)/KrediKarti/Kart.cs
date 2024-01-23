using MyKrediKarti.KartBilesenleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKrediKarti.KrediKarti
{
    public class Kart
    {
        public KartBilgileri kartBilgileri { get; set; }
        public Kartdetay kartdetay { get; set; }
        public KartSahibi kartSahibi { get; set; }  
    }
}
