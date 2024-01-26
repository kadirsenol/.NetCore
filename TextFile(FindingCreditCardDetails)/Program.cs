using MyKrediKarti.KartBilesenleri;
using MyKrediKarti.KrediKarti;

namespace MyKrediKarti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kart kart = new Kart();
            kart.kartBilgileri = new KartBilgileri();
            Console.WriteLine("Lütfen 16 Haneli Kart Numaranızı Giriniz..");
            kart.kartBilgileri.kartno = Console.ReadLine(); //"4402930032093878"          
        }
    }
}
