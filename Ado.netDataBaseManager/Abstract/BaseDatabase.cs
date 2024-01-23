using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.netDataBaseManager.Abstract
{
    public class BaseDatabase
    {
        public IDbConnection connection { get; set; }
        public IDbCommand command { get; set; }
        public IDataReader reader { get; set; }

        public BaseDatabase(IDbConnection connection)
        {
           connection.Open();
           command= connection.CreateCommand();
        }
    }
}
