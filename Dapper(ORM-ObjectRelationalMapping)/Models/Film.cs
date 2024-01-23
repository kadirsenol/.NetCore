using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_ORM_ObjectRelationalMapping_.Models
{
    
    public class Film
    {
        public int Id { get; set; }
        public string FilmAdi { get; set; }
        public string Aciklama { get; set; }
        public int Sure { get; set; }
    }
}
