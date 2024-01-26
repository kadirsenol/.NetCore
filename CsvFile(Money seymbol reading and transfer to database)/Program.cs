using CSV_file_reading_and_transfer_to_database_.Concrete;
using System.Data.SqlClient;

namespace CSV_file_reading_and_transfer_to_database_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string constr = $@"Server=.;Database=test;Trusted_Connection=True;";
            SqlConnection connection= new SqlConnection(constr);
            Csvfile csvfile = new Csvfile();
            csvfile.Readfile();
            Console.WriteLine("Lokalinizde ki csv dosyası başarılı şekilde çekildi.");
            csvfile.Split();
            Console.WriteLine("Csv dosyasına uygun modele veriler aktarıldı");
            Database db = new Database();
            db.Createtable(connection);
            Console.WriteLine("Csv dosyasına uygun tabla veritabanında oluşturuldu.");
            db.Insert(connection,csvfile.currencys);
            Console.WriteLine("Veriler veritabanına aktarıldı.");
            Console.WriteLine("Hello, World!");
        }
    }
}
