using Reflection_futboolerexample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_futboolerexample.Concrete
{
    public class Forvet:Futbolcu,IFutbolcu,IForvet
    {
        public string sprintguc { get; set; }

        public Forvet(string formano, string ad, string soyad) : base(formano,ad,soyad)
        {
        }

        public void sutcek()
        {
            throw new NotImplementedException();
        }

        public string pasver()
        {
            Console.WriteLine($@"Forvet {ad} {soyad} pas verdi");
            return $@"Forvetten {soyad} {ad} pas verdi";
        }

        public void kos()
        {
            throw new NotImplementedException();
        }

        public string golat()
        {
            Console.WriteLine($@"Forvetten {ad} {soyad} gol atti");
            return $@"Forvet {soyad} {ad} gol atti";
        }

        public void penaltıat()
        {
            throw new NotImplementedException();
        }

        public void frikikat()
        {
            throw new NotImplementedException();
        }

        public void kaleciyebas()
        {
            throw new NotImplementedException();
        }

        public void bosakac()
        {
            throw new NotImplementedException();
        }
    }
}
