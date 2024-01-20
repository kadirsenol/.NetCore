using Reflection_futboolerexample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_futboolerexample.Concrete
{
    public class Ortasaha:Futbolcu,IFutbolcu,IOrtasaha
    {

        public string IQSeviyesi { get; set; }

        public Ortasaha(string formano, string ad, string soyad) : base(formano, ad, soyad)
        {
        }

        public void sutcek()
        {
            throw new NotImplementedException();
        }

        public string pasver()
        {
            Console.WriteLine($@"Ortasaha {ad} {soyad} pas verdi");
            return $@"Ortasahadan {soyad} {ad} pas verdi";
        }

        public void kos()
        {
            throw new NotImplementedException();
        }

        public void oyunkur()
        {
            throw new NotImplementedException();
        }

        public string arapasiver()
        {
            Console.WriteLine($@"Ortasahadan {ad} {soyad} ara pas verdi");
            return $@"Ortasahadan {soyad} {ad} arapası verdi";
        }

        public void ingilizpasiver()
        {
            throw new NotImplementedException();
        }

        public void adameksilt()
        {
            throw new NotImplementedException();
        }
    }

}
