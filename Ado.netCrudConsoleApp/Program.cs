using Ado.netWithInterface.Concrete;

namespace Ado.netWithInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string constr = "Server=.;Database=test;Trusted_Connection=True;";

            do
            {
                Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz.\n1-Read\n2-Insert\n3-Delete\n4-Update\n5-Create\n6-Cikis");
                int secim = int.Parse(Console.ReadLine());
                if (secim == 0)
                {
                    Console.WriteLine("Lütfen SQL Cümlenizi Giriniz");
                    string sqlrdr = Console.ReadLine();
                    DataBase db = new DataBase();
                    db.Command = db.SqlConnection(constr);
                    db.ExecuteReader(sqlrdr);
                }
                else if (secim == 1 || secim == 2 || secim == 3 || secim == 4 || secim == 5)
                {
                    Console.WriteLine("Lütfen SQL Cümlenizi Giriniz");
                    string sqlcrud = Console.ReadLine();
                    DataBase db = new DataBase();
                    db.Command = db.SqlConnection(constr);
                    db.ExecuteNonQuery(sqlcrud);
                }
                else if (secim == 6)
                {
                    Console.WriteLine("Cikis Yaptınız..");
                    break;
                }
                Console.WriteLine("İşleminiz Basariyla Gerceklesmistir.");
            } while (true);

        }
    }
}
