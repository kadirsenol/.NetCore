using Dapper;
using Dapper_ORM_ObjectRelationalMapping_.Abstract;
using Dapper_ORM_ObjectRelationalMapping_.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_ORM_ObjectRelationalMapping_.Concrete
{
    public class Database :  IDatabase
    {
        
        public void ExecuteNonQuery(IDbConnection Connection,string sql)
        {
            Connection.Execute(sql);//for all crud command
        }

        public void ExecuteReader(IDbConnection Connection,string sql)
        {
            Filmler films = new Filmler();
            films.filmler=Connection.Query<Film>(sql).ToList();

            
        }
    }
}
