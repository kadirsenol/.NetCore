using GenericRepository_UsingDapper_.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository_UsingDapper_.Models
{
    [Table("Shippers")]
    public class Shipper : BaseEntity<int>
    {
        public string CompanyName { get; set; }
        public string Phone { get; set; }
    }
}
