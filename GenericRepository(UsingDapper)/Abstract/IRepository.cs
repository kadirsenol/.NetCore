using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository_UsingDapper_.Abstract
{
    public interface IRepository<T,TId> 
    {
        public void Delete(T entity);
        public void Update(T entity);
        public long Insert(T entity);
        public IEnumerable<T> GetAll();

        public void GetById(TId Id);
    }
}
