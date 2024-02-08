using soliD_DependencyInversionPrincible_.Concrete;

namespace soliD_DependencyInversionPrincible_
{
    internal class Program
    {
        //Dependency kavramını; Loglayıcı sınıfı File ve Mail sınıflarına doğrudan bağımlıdır yani onlara ihtiyaç duyacaktır.
        //Bu bağımlılığını sınıflar üzerinden değil de ikisindede ortak olan loglanabilir özelliğini ele alıp-
        //ILoglanabilir arayüzü üzerinden sağlayarak açıklamaya çalıştım. Bu örneği ise bir logger olarak tasarladım.
        static void Main(string[] args)
        {
            File_ file = new File_();
            Mail mail = new Mail();
            Loglayici loglayici = new Loglayici(mail,"Bu bir loglama mesajidir.");

        }
    }
}
