using Ado.netCrudFormApp.DataBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.netCrudFormApp.Abstract
{
    public interface IDataBase
    {
        public void sqlConnection(string constr);
        public void ExecuteNonQuary(SqlCommand command);
        public Personeller ExecuteReader(SqlCommand command);
    }
}
