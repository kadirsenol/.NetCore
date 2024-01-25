using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEBAPI_XmlFile_for_TCMB_.Models
{
    public class Döviz
    {
        public int Id { get; set; }
        public string CurrencyCode { get; set; }
        public string Currency { get; set; }
        public decimal ForexBuying { get; set; }
        public decimal ForexSelling { get; set; }
    }
}
