using System.Data.SqlClient;
using WEBAPI_JSON_File_.Concrete;

namespace WEBAPI_JSON_File_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection($@"Server=.;Database=test;Trusted_Connection=True;");
            Webclient webclient = new Webclient();
            webclient.Wc($@"https://northwind.netcore.io/customers.json");
            DatabaseDapper dbp = new DatabaseDapper();
            dbp.createtable(connection);
            dbp.insertdatabase(connection, webclient.customerss);
            
            Console.WriteLine("İşlemlerin tümü başarıyla gerçekleşti.!");
        }
    }
}
