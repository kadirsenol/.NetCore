using Reflection_futboolerexample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_futboolerexample.Concrete
{
    public class Kaleci:Futbolcu,IFutbolcu,IKaleci
    {
        public string boy { get; set; }
        public Kaleci(string formano_, string ad_, string soyad_) : base(formano_, ad_, soyad_)
        {
        }

        public void sutcek()
        {
            throw new NotImplementedException();
        }

        public string pasver()
        {
            Console.WriteLine($@"Kaleci {ad} {soyad} pas verdi");
            return $@"Kaleci {soyad} {ad} pas verdi";
        }

        public void kos()
        {
            throw new NotImplementedException();
        }

        public string toptut()
        {
            Console.WriteLine($@"Kaleci {ad} {soyad} top tuttu");
            return $@"Kaleci {soyad} {ad} topu tuttu";
        }

        public void suttut()
        {
            throw new NotImplementedException();
        }

        public void penaltitut()
        {
            throw new NotImplementedException();
        }

        public void outkullan()
        {
            throw new NotImplementedException();
        }

        public void degajkullan()
        {
            throw new NotImplementedException();
        }
    }
}
