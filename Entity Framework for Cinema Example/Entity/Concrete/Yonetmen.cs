using Cinema.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Entity.Concrete
{
    public class Yonetmen : BaseEntity
    {
        public string Ad { get; set; }
        public int? Yas { get; set; }
        public ICollection<Film> Filmler { get; set; } = new List<Film>();
    }
}
