using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.netWithInterface.Abstract
{
    public interface IDataBase
    {
        public SqlCommand SqlConnection(string constr);
        public void ExecuteNonQuery(string sql);
        public void ExecuteReader(string sql);
    }
}
