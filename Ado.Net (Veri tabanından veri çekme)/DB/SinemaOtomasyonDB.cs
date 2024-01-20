using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.Net__Veri_tabanından_veri_çekme_.DB
{
    public class SinemaOtomasyonDB
    {
        public List<Film> Filmler { get; set; }
        public List<Hafta> Haftalar { get; set; }
        public List<Kategori> Kategoriler { get; set; }
        public List<Salon> Salonlar { get; set; }
        public List<Seans> Seanslar { get; set; }
        public List<yonetmenadi> Yonetmenler { get; set; }

    }
}
