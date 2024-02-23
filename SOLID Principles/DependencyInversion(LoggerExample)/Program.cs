using soliD_DependencyInversionPrincible_.Concrete;

namespace soliD_DependencyInversionPrincible_
{
    internal class Program
    {
        /*DependencyInversion ==> Üst seviye modülün alt seviye modüle bağlı olmaması, soyutlamaya bağlı olması istenir.
          Böylelikle sistemde degisiklik yapmak kolaylasir ve modullerin birbiri ile iliskilerini gevsek hale getirir.*/

        //DependencyInversion kavramını; Loglayıcı sınıfı, File ve Mail sınıflarına doğrudan bağımlıdır yani onlara ihtiyaç duyacaktır.
        //Bu bağımlılığını sınıflar üzerinden değil de bagımlı oldugu modullerin ortak olan loglanabilir özelliğini ele alıp ILoglanabilir
        //arayüzü üzerinden sağlayarak açıklamaya çalıştım. Böylelikle üst seviye modülün alt seviye modüle olan bağımlılılığını bir arayüz
        //kullanarak soyutlamaya bağımlı kılıp, BAGIMLILIK TERSİNE CEVRİLMESİ prensibini gerceklestirmis oldum. Bu örneği ise bir logger olarak tasarladım.
        static void Main(string[] args)
        {
            File_ file = new File_();
            Mail mail = new Mail();
            Loglayici loglayici = new Loglayici(mail,"Bu bir loglama mesajidir.");

        }
    }
}
