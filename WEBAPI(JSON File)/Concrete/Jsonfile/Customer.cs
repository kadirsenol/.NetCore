using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEBAPI_JSON_File_.Concrete.Jsonfile
{
    [Dapper.Contrib.Extensions.Table("Customers")]
    public class Customer
    {
        [Key]
        public string id { get; set; }
        public string? companyName { get; set; }
        public string? contactName { get; set; }
        public string? contactTitle { get; set; }
        public string? address { get; set; }
        public string? city { get; set; }
        public string? postalCode { get; set; }
        public string? country { get; set; }
        public string? phone { get; set; }
        public string? fax { get; set; }

    }
}
