using Ado.netDataBaseManager.Abstract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.netDataBaseManager.Concrete
{
    public class Database : BaseDatabase, IDatabase
    {
        public Database(IDbConnection connection) : base(connection)
        {
                  
        }
        public void Execute(string sql)
        {
            command.CommandText = sql;
            command.ExecuteNonQuery();  
        }

        public IDataReader ExecuteRead(string sql)
        {
            command.CommandText = sql;
            reader = command.ExecuteReader();
            return reader;
        }
    }
}
