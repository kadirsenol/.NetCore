using CSV_file_reading_and_transfer_to_database_.Abstract;
using CSV_file_reading_and_transfer_to_database_.Concrete.DB;
using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_file_reading_and_transfer_to_database_.Concrete
{
    public class Database : IDatabase
    {
        public void Createtable(IDbConnection connection)
        {
            string sql = $@"CREATE TABLE [Currencys](
                                       	 [Code] [nvarchar] (50) NULL,
                                       	 [Symbol] [nvarchar](50) NULL,
                                       	 [Name] [nvarchar](50) NULL
                                         )";
            connection.Execute(sql);
        }

        public void Insert(IDbConnection connection,Currencys currencys)
        {
            foreach (Currency currency in currencys.currencys)
            {
                connection.Insert<Currency>(currency);
            }
        }
    }
}
