namespace DBFirst_of_Entity_Framework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adımları CLI uzerinden gerceklestirmek uzere;
            //Makinanızda .net SDK yuklu oldugunu "dotnet ef" komutu ile kesinlestirilir
            //Projenize Microsoft Ef Core Design ve calisacaginiz veritabanın Microsoft Ef Core xxserver paketleri indirilir.
            //Locale indirilen bu paketler .net surumu ile senkron olmasi istenir. Ve indirme islemi sonrasi proje rebuild edilir.
            //Ilgılı proje dizinine konumlan.
            //dotnet ef dbcontext scaffold "connectionString" -o FolderName DbPacketName 

            Console.WriteLine("Veritabanı lokale indirme işlemi başarılı !");
        }
    }
}
