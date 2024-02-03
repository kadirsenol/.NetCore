using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository_UsingDapper_.Abstract
{
    public class BaseEntity<T>
    {
        [Key]
        public T ID { get; set; }
    }
}
