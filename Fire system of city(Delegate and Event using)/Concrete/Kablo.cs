using Fire_system_of_city_Delegate_and_Event_using_.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_system_of_city_Delegate_and_Event_using_.Concrete
{
    public class Kablo : IKablo
    {
        public event FireHandler KabloYandi;
        public string Marka { get; set; }
        public string Boyut { get; set; }
        public int MaxAkim { get; set; }
        public Kablo(int maxakim)
        {
            MaxAkim = maxakim;   
        }

        public void DumanCikar()
        {
            Console.WriteLine("Kablo yanmaya basladi");
            KabloYandi(this);
        }

        public void Fisetak()
        {
            do
            {
                Console.WriteLine("Kablo fise takilsin mi ?");
                string cevap = Console.ReadLine().ToUpper();
                if (cevap == "EVET")
                {
                    Console.WriteLine("Kablo fise takildi");
                    if (MaxAkim < 30)
                    {
                        YuksekAkimgecir();
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Kablo görevini sorunsuz yerine getiriyor :)");
                        return;
                    }
                }
                else if (cevap == "HAYIR")
                {
                    if (MaxAkim<30)
                    {
                        Console.WriteLine("Risksiz bir secim yaptınız iyi günler dilerim.. :)");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Güvenli bir secim yapmıştınız oysaki, Yine bekleriz.. :)");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen Evet veya Hayır olacak şekilde giriş yapiniz.");
                    continue;
                }
            } while (true);
            
        }

        public void YuksekAkimgecir()
        {
            Console.WriteLine("Kablodan yüksek akim geciyor");
            DumanCikar();
        }
    }
}
