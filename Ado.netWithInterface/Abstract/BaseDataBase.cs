using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.netWithInterface.Abstract
{
    public class BaseDataBase
    {
        public string Constr { get; set; }
        public SqlConnection connection { get; set; }
        public SqlCommand Command { get; set; } 
        public SqlDataReader Reader { get; set; }
        
    }
}
