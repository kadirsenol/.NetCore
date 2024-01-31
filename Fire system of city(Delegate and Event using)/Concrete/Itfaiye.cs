using Fire_system_of_city_Delegate_and_Event_using_.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_system_of_city_Delegate_and_Event_using_.Concrete
{
    public class Itfaiye : IItfaiye
    {
        public event PoliceHandler MudehaleEtti;
        public string EkipKapasitesi { get; set; }

        public void MudehaleEt(object yanan, EventArgs e) // Tetikleyen ve tetiklenen (burası) sınıf arasında iletişim
        {                                                 // EventArg tipinde ki e nesnesi üzerinden sağlanmış oldu.
            if (yanan is Kablo)
            {
                KabloEventArgs kablotakan = (KabloEventArgs)e;
                Console.WriteLine($@"{kablotakan.KabloyuTakanAd}'in taktığı kablo sonucu çıkan yangına itfaiye müdehale etti ve yangın söndürüldü.");
                MudehaleEtti();
            }
            else if(yanan is Sigara)
            {
                Console.WriteLine("Sigara dumanı itfaiyelik bir durumu teşkil etmediğinden itfaiye harekete gecmedi.");
            }

        }
    }
}
