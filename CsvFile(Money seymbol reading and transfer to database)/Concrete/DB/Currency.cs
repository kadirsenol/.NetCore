using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_file_reading_and_transfer_to_database_.Concrete.DB
{
    [Table("Currencys")]
    public class Currency
    {
        public string Code { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }

    }
}
