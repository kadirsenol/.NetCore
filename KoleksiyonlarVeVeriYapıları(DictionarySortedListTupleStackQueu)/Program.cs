using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace KoleksiyonVeVeriYapıları_DictionarySortedListTupleStackQueu_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kisi ahmet = new Kisi() { Ad = "Ahmet", Soyad = "Yilmaz", Yas = 20 };
            Kisi ali = new Kisi() { Ad = "Ali", Soyad = "Demir", Yas = 25 };
            #region Dictionary
            //Key Value ilişki temeline dayanan ve Key degerine direk ulaşılması nedeni ile tercih edilirler.
            //Generic yapısı gereği her türlü veri türleri ile olusturulma esnekligine sahiptirler.
            //Aynı keye sahip birden fazla value degeri olamaz. Aynı key tekrar eklenmeye calisildiginda override(uzerine yaz) eder.
            //Tanımlanması:
            Dictionary<int,Kisi> kisiler = new Dictionary<int,Kisi>();
            kisiler.Add(7, ahmet);
            kisiler.Add(5, ali);

            //İstenilen key e doğrudan ulaşım vardır. Key Hash ile şifrelendiği için performansı çok hızlıdır. (Key i 5 olan kisinin soyadi)
            Console.WriteLine(kisiler[5].Soyad);

            //Değerler sıralı şekilde tutulmaz.
            foreach (var item in kisiler)
            {
                Console.WriteLine(((Kisi)item.Value).Ad); //Casting uygulaması.
            }
            #endregion

            #region SortedList
            //Key Value ilişki temeline dayanan ve Key degerine direk ulaşılması nedeni ile tercih edilirler. Dictionary lere göre binary sıralaması yaptıklarından Key degerine daha yavas ulasırlar.
            //Key tipi IComparable(sayılabilir) arayüzünü uygulamalıdır ki sıralama yapabilsin. Value türü tüm veri tiplerini alabilir.
            //Aynı keye sahip birden fazla value degeri olamaz. Aynı key tekrar eklenmeye calisildiginda override(uzerine yaz) eder.

            //Tanimlanmasi;
            SortedList<int, Kisi> kisilers = new SortedList<int, Kisi>();
            kisilers.Add(3, ahmet);
            kisilers.Add(1, ali);

            //İstenilen key e doğrudan ulaşım vardır. Key binary ile şifrelendiği için performansı dictionary e nazaran daha yavastir. (Key i 3 olan kisinin soyadi)
            Console.WriteLine(kisilers[3].Soyad);

            //Değerler sıralı şekilde tutulur. Dictionary ile farkları budur.
            foreach (var item in kisilers)
            {
                Console.WriteLine(((Kisi)item.Value).Ad); //Casting uygulaması.
            }
            #endregion

            #region Tuple
            //Metotlarda birden fazla tipin return edilmesi istenildiginde tercih edilirler. Generic yapi geregi max 8 adet farkli her turden veri turu kabul eder.
            //Tuple veri yapilari aslinda arka tarafta generic yapili bir class icerisinde field lardan ibarettir. Return olanlar da aslında bu fieldlerdir.
            //Bu degerler fieldlere ctor ile atanir. Instance alımında bu itemler bu nedenle istenir.
            //Bir row data tutarlar.

            //Tanimlanmasi;
            Tuple<int, string, Kisi> tuple1 = new Tuple<int, string, Kisi>(1,"Turkey",ahmet);

            //Icerisinde ki verilere item1-2-3 seklinde field(item) uzerinden ulasilir.
            Console.WriteLine(tuple1.Item3.Ad+" "+tuple1.Item2);

            //Metotlarda birden fazla turu geri dondurmek icin kullanılırlar
            Tuple<int, string, Kisi> tuple3 = BirdenfazlaReturn(ahmet);
            Console.WriteLine(tuple3.Item2+" "+tuple3.Item3.Yas);

            #endregion

            #region Stack Last in first out
            //Bir bulasik tabaklari orneginde ki tabaklardan en son koyulan en ilk alinir. Generic yapisi ile her turden veri turu kabul eder.

            //Tanimlanmasi;
            Stack<int> sayilar = new Stack<int>();
            sayilar.Push(1);
            sayilar.Push(2);
            sayilar.Push(3);

            Console.WriteLine(sayilar.Peek());//Ilk sıradaki(en son koyulan)


            Console.WriteLine(sayilar.Pop() + " silindi");//En son eklenen ogeyi siler ve geri dondurur.
            foreach (int item in sayilar)
            {
                Console.WriteLine(item);//Sayilarda en son eklenen oge silindi.
            }

            #endregion

            #region Queue First in first out
            //Bir banka sira kuyrugunda siraya ilk giren ilk cikar.

            //Tanimlanmasi;
            Queue<Kisi> kisilerq = new Queue<Kisi>();
            kisilerq.Enqueue(ahmet);
            kisilerq.Enqueue(ali);
            
            Console.WriteLine(kisilerq.Peek().Ad);//Ilk sirada ki(En ilk giren)

            Console.WriteLine(kisilerq.Dequeue().Ad + " silindi");//Kisilerde en ilk eklenen kisiyi siler ve geri dondurur.
            foreach (var item in kisilerq)
            {
                Console.WriteLine(item.Ad);//Kisilerde en ilk giren kisi silindi.
            }


            #endregion


        }

        public static Tuple<int, string, Kisi> BirdenfazlaReturn(Kisi kisi)
        { 
            Tuple<int, string, Kisi> tuple2 = new Tuple<int, string, Kisi>(3,"Turkey",kisi);
            return tuple2;
            /*Alternatif
            return Tuple.Create(3, "Turkey", kisi);*/
        }
    }
}
