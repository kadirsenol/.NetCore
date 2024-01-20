using Reflection_futboolerexample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_futboolerexample.Concrete
{
    public class Defans : Futbolcu,IFutbolcu,IDefans
    {
        public string fizikgucu { get; set; }
        public Defans(string formano, string ad, string soyad) : base(formano, ad, soyad)
        {
            
        }

        public void adamtut()
        {
            throw new NotImplementedException();
        }

        public string kafatopucik()
        {
            Console.WriteLine($@"Defanstan {soyad} {ad} kafatopuna cikti");
            return $@"Defanstan {soyad} {ad} kafatopuna cikti";
        }

        public void kay()
        {
            throw new NotImplementedException();
        }

        public void kos()
        {
            throw new NotImplementedException();
        }

        public string pasver()
        {
            Console.WriteLine($@"Defans {ad} {soyad} pas verdi");
            return $@"Defanstan {soyad} {ad} pas verdi";
        }

        public void sutcek()
        {
            throw new NotImplementedException();
        }

        public void topkes()
        {
            throw new NotImplementedException();
        }
    }
}
