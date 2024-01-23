using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.netDataBaseManager.Abstract
{
    public interface IDatabase
    {
        public void Execute(string sql);
        public IDataReader ExecuteRead(string sql);
    }
}
