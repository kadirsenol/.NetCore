using Fire_system_of_city_Delegate_and_Event_using_.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_system_of_city_Delegate_and_Event_using_.Concrete
{
    public class Police : IPolice
    {
        public int EkipSayisi { get; set; }
        public void olayYeriIncele()
        {
            Console.WriteLine("Olay yeri inceleme polis ekipleri olay yerine intikal etti.");
        }
    }
}
