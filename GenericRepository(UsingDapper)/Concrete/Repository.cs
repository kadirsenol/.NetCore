using Dapper.Contrib.Extensions;
using GenericRepository_UsingDapper_.Abstract;
using GenericRepository_UsingDapper_.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository_UsingDapper_.Concrete
{
    public class Repository<T,TId> : IRepository<T,TId> where T : BaseEntity<TId>
    {
        public IDbConnection Connection { get; set; }
        public Repository(IDbConnection connection)
        {
            Connection = connection;
        }
        public void Delete(T entity)
        {
            Connection.Delete<T>(entity);
        }

        public void GetById(TId Id)
        {
            Connection.Get<T>(Id);
        }

        public IEnumerable<T> GetAll()
        {
           return Connection.GetAll<T>();
        }

        public long Insert(T entity)
        {
           return Connection.Insert<T>(entity);
        }

        public void Update(T entity)
        {
            Connection.Update<T>(entity);
        }
    }
}
