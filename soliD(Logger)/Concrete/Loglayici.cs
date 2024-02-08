using soliD_DependencyInversionPrincible_.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soliD_DependencyInversionPrincible_.Concrete
{
    public class Loglayici : ILoglayici
    {

        #region Constructor Injection
        //LLoglayıcı sınıfına, bağımlı olduğu loglanabilir yeteneğine sahip nesnelerin ILoglanabilir yeteneği üzerinden constructor ile enjekte edilmesi.
        public Loglayici(ILoglanabilir loglanabilir, string msg)
        {
            loglanabilir.Loglan(msg);
        }
        #endregion

        #region Method Injection(II. Yol)
        //Loglayıcı sınıfına, bağımlı olduğu loglanabilir yeteneğine sahip nesnelerin ILoglanabilir yeteneği üzerinden metot ile enjekte edilmesi.


        public void Logla(ILoglanabilir loglanabilir, string msg)
        {
            loglanabilir.Loglan(msg);
        }
        #endregion

    }
}
