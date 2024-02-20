using Cinema.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Entity.Concrete
{
    public class Seans : BaseEntity
    {
        public string SeansSaat { get; set; }
        public ICollection<Bilet> Biletler { get; set; } = new List<Bilet>();
    }
}
