using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Ado.netCrudFormApp.DataBase
{
    public class Personel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string  Departman { get; set; }
        public Bolge bolgesi { get; set; }
    }
}
