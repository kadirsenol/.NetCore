namespace ExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lutfen Turkce karakterlerin silinmesini istediginiz kelimeyi giriniz");
            string kelime = (Console.ReadLine()).ToLower();
            kelime =kelime.NonTurkishChar(); // Olusturulan Extension Metod.
            Console.WriteLine("Iste yeni kelime: "+kelime);
        }
    }
}
