using Fire_system_of_city_Delegate_and_Event_using_.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_system_of_city_Delegate_and_Event_using_.Concrete
{
    public class Kisi : BaseKisi, IKisi
    {
        public Kisi(string ad)
        {
            Ad = ad;
        }
        public void Kac(object yanan)
        {
            if (yanan is Kablo) 
            {
                Console.WriteLine($"{Ad} yangindan kacti");
            }
            else if (yanan is Sigara)
            {
                Console.WriteLine($"{Ad} sigara dumanından uzaklasip kacti");
            }

        }

        public void RahatsizOl(object yanan)
        {
            if (yanan is Kablo)
            {
             Console.WriteLine($"{Ad} alarm sesini duyar duymaz rahatsiz oldu.");
            }
            else if (yanan is Sigara)
            {
             Console.WriteLine($"{Ad} sigara dumanından rahatsiz oldu.");
            }

        }

        public void GerekeniYap(object yanan)
        {
            if (yanan is Kablo)
            {
             Console.WriteLine($"{Ad} yangini sondurebilmek icin su bulmaya calisti.");
            }
            else if (yanan is Sigara)
            {
                Console.WriteLine($"{Ad} Sigara icen kisiyi uyardı.");
            }

        }
    }
}
