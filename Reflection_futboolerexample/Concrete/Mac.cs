using Reflection_futboolerexample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_futboolerexample.Concrete
{
    public class Mac : IMac
    {
        public void defans(IDefans idefans)
        {
            idefans.kafatopucik();
        }

        public void forvet(IForvet iforver)
        {
            iforver.golat();
        }

        public void futbolcu(IFutbolcu ifutbolcu)
        {
            ifutbolcu.pasver();
        }

        public void kaleci(IKaleci ikaleci)
        {
            ikaleci.toptut();
        }

        public void ortasaha(IOrtasaha iortasaha)
        {
            iortasaha.arapasiver();
        }
    }
}
