using Cinema.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Entity.Concrete
{
    public class Bilet : BaseEntity
    {
        public int FilmId { get; set; }
        public virtual Film Film { get; set; }
        public int SalonId { get; set; }
        public virtual Salon Salon { get; set; }
        public int SenasId { get; set; }
        public virtual Seans Seans { get; set; }
        public int TarihId { get; set; }
        public virtual Tarih Tarih { get; set; }
    }
}
