using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.netCrudFormApp.Abstract
{
    public class BaseDataBase
    {
        public SqlConnection Sqlconnection { get; set; }
        public SqlCommand Sqlcommand { get; set; }
        public SqlDataReader reader { get; set; }
        public string constr { get; set; }  
    }
}
