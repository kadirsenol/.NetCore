using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soliD_DependencyInversionPrincible_.Abstract
{
    public interface ILoglayici
    {
        public void Logla(ILoglanabilir loglanabilir,string msg);
    }
}
