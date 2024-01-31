using Fire_system_of_city_Delegate_and_Event_using_.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_system_of_city_Delegate_and_Event_using_.Concrete
{
    public class Sigara : ISigara
    {
        public event FireHandler Sigarayandi;
        public string Marka { get; set; }

        public void dumanCikar()
        {
            EventArgs eventArgs = new EventArgs();
            Sigarayandi(this,eventArgs);
            
        }

        public void pakettenCik()
        {
            do
            {
                Console.WriteLine("Sigara paketten cikartilsin mi ?");
                string cevap = Console.ReadLine().ToUpper();

                if (cevap == "EVET")
                {
                    Console.WriteLine("Sigara paketten çıkartıldi");
                    Console.WriteLine("Sigara yakilsin mi ?");
                    string cevap2 = Console.ReadLine().ToUpper();
                    if (cevap2 == "EVET")
                    {
                        Yan();
                        return;
                    }
                    else if (cevap2 == "HAYIR")
                    {
                        Console.WriteLine("Sağlikli yasamı tercih ettiğiniz icin tesekkur ederiz :)");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen Evet veya Hayır giriniz.");
                        continue;
                    }
                }
                else if (cevap == "HAYIR")
                {
                    Console.WriteLine("Sağlıkli yaşamı tercih ettiğiniz için teşekkür ederiz :)");
                    return;
                }
                else
                {
                    Console.WriteLine("Lütfen Evet veya Hayır giriniz.");
                    continue;
                }
            } while (true);
           
        }

            public void Yan()
            {
            Console.WriteLine("Sigara yakildi");
            dumanCikar();
            }
    }

    
}
