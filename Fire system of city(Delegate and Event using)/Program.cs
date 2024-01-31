using Fire_system_of_city_Delegate_and_Event_using_.Concrete;
using System.Xml.Serialization;

namespace Fire_system_of_city_Delegate_and_Event_using_
{
    public delegate void FireHandler(object nesne, EventArgs e);
    public delegate void SparkHandler(object nesne);
    public delegate void PoliceHandler();
    internal class Program
    {
        static void Main(string[] args)
        {
            DumanDedektor dumanDedektor = new DumanDedektor();
            Sigara sigara = new Sigara();
            Itfaiye itfaiye = new Itfaiye();
            Police police = new Police();
            Kisi Kadir = new Kisi("Kadir");
            Kisi Ali = new Kisi("Ali");
            Kisi Ayse = new Kisi("Ayse");

            sigara.Sigarayandi += dumanDedektor.DumanAlgila;
            dumanDedektor.AlarmCaldi += Kadir.GerekeniYap;
            dumanDedektor.AlarmCaldi += Ali.Kac;
            dumanDedektor.AlarmCaldi += Ayse.RahatsizOl;
            dumanDedektor.AlarmHaberGecti += itfaiye.MudehaleEt;
            itfaiye.MudehaleEtti += police.olayYeriIncele;

            do
            {
                Console.WriteLine("Merhaba ben akıllı olay asistanı Clican, size nasıl yardımcı olabilirim ? \n1-)Sigara satin al\n2-)Kablo satin al");
                int secim = int.Parse(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        sigara.pakettenCik();
                        return;
                    case 2:
                        Console.WriteLine("Lütfen kablonun max akimini giriniz, 30A altında kablolar yangın çıkarır.");
                        int maxakim = int.Parse(Console.ReadLine());
                        Kablo kablo = new Kablo(maxakim);
                        kablo.KabloYandi += dumanDedektor.DumanAlgila;
                        kablo.Fisetak();
                        return;
                    default:
                        Console.WriteLine("Lütfen 1 veya 2 olacak sekilde seciminizi giriniz.");
                        return;
                }
            } while (true);           
        }
    }
}
