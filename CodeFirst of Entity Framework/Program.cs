namespace CodeFirst_of_Entity_Framework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //İlgili entity classlari ve dbcontext class i olusturulduktan sonra adımları CLI uzerinden gerceklestirmek uzere;
            //Makinanızda .net SDK yuklu oldugunu "dotnet ef" komutu ile kesinlestirilir
            //Projenize Microsoft Ef Core Design ve calisacaginiz veritabanın Microsoft Ef Core xxserver paketleri indirilir.
            //Locale indirilen bu paketler .net surumu ile senkron olmasi istenir. Ve indirme islemi sonrasi proje rebuild edilir.
            //Ilgılı proje dizinine konumlan.
            //Ilgili proje set as a start up project olmali.
            //dotnet ef migrations add 'processname' // birden fazla db ile calisilacak ise==> … --context "contextclassname"
            //dotnet ef database update

            Console.WriteLine("Ilgili entityler referans alinarak veritabani olusturuldu");
        }
    }
}
