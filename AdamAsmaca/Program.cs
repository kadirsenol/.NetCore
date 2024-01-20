using System.Diagnostics.Metrics;
using System;
namespace oyunarsaloto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> liste = new List<string>()
            {
                "kale","bilgisayar","yazılım","tablo","kitap","oyun","lamba",
                "kalem","masa","telefon"
            };
            Console.WriteLine("Listeden bir kelime seçmek için 1-10 arası rakam giriniz:");
            int numara =int.Parse(Console.ReadLine());
            string kelime = liste[numara-1];
            string secilenkelime = kelime;
            string gizlikelime = "";
            for (int i = 0; i < kelime.Length; i++)
            {
                gizlikelime += "*";
            }
            Console.WriteLine("Bulmanı Gereken Gizli Kelime:" + gizlikelime);
            int hak = 5;
            bool flag = false;
            for (int i = 0; i < hak; i++)
            {
                Console.WriteLine($@"Bir harf tahmin edin, tahmin hakkınız:{hak-i}");
                char girilenharf = char.Parse(Console.ReadLine());
                if (secilenkelime.Contains(girilenharf))
                {

                    for (int a = 0; a < secilenkelime.Length; a++)
                    {
                        if (secilenkelime[a] == girilenharf)
                        {
                            gizlikelime = gizlikelime.Substring(0, a) + girilenharf
                           + gizlikelime.Substring(a + 1);

                        }
                    }
                    if (gizlikelime != secilenkelime)
                    {
                        Console.WriteLine("Tebrikler Bir Harf Bildiniz: " +
                       gizlikelime);
                        i--;
                    }
                    
                    }
                    else
                    {
                        if (i == 4)
                        {
                            Console.WriteLine("Maalesef hakkınız sona erdi.. :(");
                        }
                        continue;
                    }
                if (gizlikelime == secilenkelime)
                {
                    Console.WriteLine("Tebrikler. Kelimeyi Buldunuz! :) "+secilenkelime.ToUpper());
                    break;
                }
                  
            }
        }
    }
}