using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;

namespace WEBAPI_JSON_File_.Concrete.Jsonfile
{
    [Dapper.Contrib.Extensions.Table("Customers")]
    public class Customers
    {
        public List<Customer> results { get; set; } = new List<Customer>();
     
    }
}
