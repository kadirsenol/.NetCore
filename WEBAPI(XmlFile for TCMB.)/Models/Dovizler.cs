using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace WEBAPI_XmlFile_for_TCMB_.Models
{
    public class Dovizler
    {
        public List<Doviz> dovizler { get; set; } = new List<Doviz>();
    }
}
