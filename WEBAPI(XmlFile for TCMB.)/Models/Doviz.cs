using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dapper;

namespace WEBAPI_XmlFile_for_TCMB_.Models
{
    
    public class Doviz
    {
        
        public string? Currency { get; set; }
        public string ForexBuying { get; set; }
        public string ForexSelling { get; set; }
    }
}
