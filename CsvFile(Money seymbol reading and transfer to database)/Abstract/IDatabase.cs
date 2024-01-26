using CSV_file_reading_and_transfer_to_database_.Concrete.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_file_reading_and_transfer_to_database_.Abstract
{
    public interface IDatabase
    {
        public void Createtable(IDbConnection connection);
        public void Insert(IDbConnection connection, Currencys currencys);
    }
}
