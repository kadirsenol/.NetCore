using System.Threading.Channels;

namespace ActionFuncPredicateDelegate_UsingWhereForEachMethod_
{
    internal class Program
    {      
        static void Main(string[] args)
        {

            List<Kisi> kisi = new List<Kisi>()
        {
            new Kisi(){Id=1, Ad="Ali", Soyad="Yilmaz"},  //Anonim instance alma.
            new Kisi(){Id=2, Ad="Ayse", Soyad="Kaya"}
        };
            Kisi ahmet = new Kisi() {Id=3, Ad="Ahmet", Soyad="Demir" }; //İsimli instance alma
            kisi.Add(ahmet);
            Kisi ali = new Kisi()
            {
                Id = 4,
                Ad = "Ali",
                Soyad = "Çolak"
            };
            kisi.Add(ali);
            

            #region Action Delegate

            //Parametresiz tanımlama çeşitleri
            Action action = new Action(NonParameters);
            Action action1 = NonParameters;
            action += NonParameters;
            //Run çeşitleri
            action();
            action1.Invoke();

            //Parametreli tanımlama çeşitleri
            Action<Kisi> action2 = new Action<Kisi>(YesParameters);
            Action<Kisi> action3 = YesParameters;
            Action<Kisi> action4 = p => Console.WriteLine(p.Soyad);
            action4 += YesParameters;
            //Run çeşitleri
            action2(ahmet);
            action3.Invoke(ahmet);
            action4(ahmet);
            action4.Invoke(ahmet);

            #endregion

            #region Func Delegate
            //Tanımlama Çeşitleri
            Func<string> func = new Func<string>(YesReturnNoParameters);
            Func<Kisi, string> func1 = new Func<Kisi, string>(YesParametersReturn);
            Func<Kisi, string> func2 = YesParametersReturn;
            Func<Kisi, string> func3 = p => p.Ad;
            func3 += YesParametersReturn;

            //Run Çeşitleri
            func();
            func1(ahmet);
            func2.Invoke(ahmet);

            #endregion

            #region Predicate Delegate

            // Predicate delegate = Bool geri dönen ve içerisine parametre alan func delegate.
            Func<Kisi, bool> func5 = new Func<Kisi, bool>(BoolReturnYesParameters);
            Func<Kisi, bool> func6 = p => p.Ad == "Ali";

            //Tanımlama Çeşitleri         
            Predicate<Kisi> pre7 = new Predicate<Kisi>(BoolReturnYesParameters);
            Predicate<Kisi> pre8 = p => p.Ad == "Ali";
            Predicate<Kisi> pre9 = BoolReturnYesParameters;
            pre9 += BoolReturnYesParameters;

            //Run Çeşitleri
            pre7(ahmet);
            pre8.Invoke(ahmet);
            pre9.Invoke(ahmet);
            Console.WriteLine(pre9(ahmet));
            #endregion

            #region Using Where Method (With First and FirstOrDefault Methods)

            //İçerisine bool geri dönüş sağlayan func delegate parametresi geçilen metottur

            //Tanımlama Çeşitleri
            kisi.Where(func5);
            kisi.Where(p => p.Id == 3);
            kisi.Where(BoolReturnYesParameters);

            //Sonucun bastırılması
            IEnumerable<Kisi> aliler = new List<Kisi>();
            aliler = kisi.Where(func6);
            Console.WriteLine("Listede ki Ali isimli kişilerin soyisimleri;");
            foreach (var item in aliler)
            {
                Console.WriteLine(item.Soyad);
            }

            Console.WriteLine("Soyadi Demir olan kişilerin adi;");
            foreach (var item in kisi.Where(p=>p.Soyad=="Demir"))
            {
                Console.WriteLine(item.Ad);
            }

            //First and FirstorDefault metotların kullanılması
            //First => Gelen sonuç listesinden ilkini getirir ve listenin en az bir eleman içermesi beklenir aksi taktirde hataya dusecektir.
            //FirstOrDefault ise => açıklamasından da anlaşılacağı üzere type? yani gelen sonuc listesinin dolu olması halinde ilk değeri verirken, bu sonuc listesinin bos deger de alabilecegini ve sonuc listesinin bu sekilde gelmesi halinde hataya düsmeden bos deger verecegini belirtir.
            Console.WriteLine(kisi.Where(p => p.Ad == "Ali").ToList().First().Id);
            Console.WriteLine(kisi.Where(p => p.Ad == "Aykut").ToList().FirstOrDefault());

            #endregion

            #region Using ForEach Method

            //İçerisine action delegate veya bu delegate in temsil ettiği metotları parametre isteyen metottur.

            //Tanımlanma Çeşitleri
            kisi.ForEach(YesParameterNoReturn);
            kisi.ForEach(action2);
            kisi.ForEach(p => Console.WriteLine(p.Id));

            //Where metodu ile kullanımı (Listede adı ali olanların soyisimleri listesi)

            kisi.Where(p => p.Ad == "Ali").ToList().ForEach(p=>Console.WriteLine(p.Soyad));
            kisi.Where(func6).ToList().ForEach(action4);
            kisi.Where(BoolReturnYesParameters).ToList().ForEach(YesParameters);
            #endregion

            #region Method parameters is Method
            //Metotlar normal kullanımlarına binaen parametre olarak metot kabul etmezler.
            //Bir metotda parametre olarak metot geçebilmenin yolu delege ile sağlanır.

            //Kullanım Çeşitleri
            Parametersisdelegate(YesParametersReturn);
            Parametersisdelegate(p=>p.Ad);
            Parametersisdelegate(func3);

            //Yukarıda ki kullanım çeşitlerinin ekrana basılması.
            Console.WriteLine(Parametersisdelegate(YesParametersReturn));
            Console.WriteLine(Parametersisdelegate(p => p.Ad));
            Console.WriteLine(Parametersisdelegate(func3));



            #endregion

        }

        #region Static Methods for using in main method
        static void NonParameters()
        {
            Console.WriteLine("Şuan parametre almayan metot çalıştı");
        }

        static void YesParameters(Kisi person)
        {
            Console.WriteLine(person.Soyad);
        }

        static string YesReturnNoParameters()
        {
            return "Şuan parametresiz string dönen metot çalıştı";
        }
        static string YesParametersReturn(Kisi person)
        {
            return person.Ad;       
        }

        static bool BoolReturnYesParameters(Kisi person)
        {
            return person.Ad=="Ali";
        }

        static void YesParameterNoReturn(Kisi kisi)
        {
            Console.WriteLine(kisi.Id + kisi.Ad + kisi.Soyad);
        }

        static string Parametersisdelegate(Func<Kisi,string> metot)
        {
            Kisi can = new Kisi() { Id = 5, Ad = "Can", Soyad = "Develi" };
            return metot.Invoke(can);
        }


        #endregion
    }
}
