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

        public void MudehaleEt(object yanan)
        {
            if (yanan is Kablo)
            {
                Console.WriteLine("İtfaiye yangına müdehale etti ve yangın söndürüldü.");
                MudehaleEtti();
            }
            else
            {
                Console.WriteLine("İtfaiyelik bir durum olmadığı için itfaiye harekete gecmedi.");
            }

        }
    }
}
