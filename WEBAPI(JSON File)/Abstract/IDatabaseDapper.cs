using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEBAPI_JSON_File_.Concrete.Jsonfile;

namespace WEBAPI_JSON_File_.Abstract
{
    public interface IDatabaseDapper
    {
        public void createtable(IDbConnection connection);
        public void insertdatabase(IDbConnection connection,Customers customers);
    }
}
