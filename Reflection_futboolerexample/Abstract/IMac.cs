using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_futboolerexample.Abstract
{
    public interface IMac
    {
        public void futbolcu(IFutbolcu ifutbolcu);
        public void defans(IDefans idefans);
        public void forvet(IForvet iforver);
        public void kaleci(IKaleci ikaleci);
        public void ortasaha(IOrtasaha iortasaha);
    }
}
