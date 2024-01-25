using Polimorfizm_Phone_Sounds_.Concrete;

namespace Polimorfizm_Phone_Sounds_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region I. Yol
            //while (true)
            //{
            //    Console.WriteLine("Lütfen Aramak İstediğiniz Telefon Markasını Seçiniz.. \n1-)IPHONE\n2-)SAMSUNG\n3-)NOKIA\n4-)Çıkış..");
            //    int number = int.Parse(Console.ReadLine());
            //    switch (number)
            //    {
            //        case 1:
            //            Apple phone1 = new Apple();
            //            phone1.play();
            //            break;
            //        case 2:
            //            Samsung phone2 = new Samsung();
            //            phone2.play();
            //            break;
            //        case 3:
            //            Nokia phone3 = new Nokia();
            //            phone3.play();
            //            break;
            //        case 4:
            //            return;
            //        default:
            //            Console.WriteLine("Hatali Seçim..");
            //            break;
            //    }
            //} 
            #endregion

            #region II. Yol (Use of Phone Class)
            while (true)
            {
                Console.WriteLine("Lütfen Aramak İstediğiniz Telefon Markasını Seçiniz.. \n1-)IPHONE\n2-)SAMSUNG\n3-)NOKIA\n4-)Çıkış..");
                int number = int.Parse(Console.ReadLine());
                Phone phone = new Phone();
                switch (number)
                {
                    case 1:
                        Apple phone1 = new Apple();
                        phone.PhoneSound(phone1);
                        break;
                    case 2:
                        Samsung phone2 = new Samsung();
                        phone.PhoneSound(phone2);
                        break;
                    case 3:
                        Nokia phone3 = new Nokia();
                        phone.PhoneSound(phone3);
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Hatali Seçim..");
                        break;
                }
            } 
            #endregion
        }
    }
}
