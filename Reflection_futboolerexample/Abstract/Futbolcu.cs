using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_futboolerexample.Abstract
{
    public abstract class Futbolcu
    {
        public string formano { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string sutgucu { get; set; }
        public string savunmagucu { get; set; }
        public string atakgucu { get; set; }
        public string pasgucu { get; set; }

        public Futbolcu(string formano_, string ad_, string soyad_)
        {
            formano= formano_;
            ad= ad_;
            soyad= soyad_;
            
        }

        public override string ToString()
        {
            return soyad+" "+ad;
        }
    }
}
