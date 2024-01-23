using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_ORM_ObjectRelationalMapping_.Abstract
{
    public interface IDatabase
    {
        public void ExecuteNonQuery(IDbConnection Connection,string sql);
        public void ExecuteReader(IDbConnection Connection,string sql);
        
    }
}
