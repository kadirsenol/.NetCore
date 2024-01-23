using Dapper_ORM_ObjectRelationalMapping_.Concrete;
using Dapper_ORM_ObjectRelationalMapping_.Models;
using System.Data.SqlClient;

namespace Dapper_ORM_ObjectRelationalMapping_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database db = new Database();
            SqlConnection connection = new SqlConnection(@$"Server=.;Database=SinemaOtomasyon;Trusted_Connection=True;");
            string sqlinsert = $@"INSERT INTO [dbo].[Filmler]
                                             ([FilmAdi]
                                             ,[Aciklama]
                                             ,[Sure])
                                       VALUES
                                             ('Esaretin Bedeli'
                                             ,'Özgürlüğe kaçış hikayesi'
                                             ,'120')";
            db.ExecuteNonQuery(connection,sqlinsert);
            Console.WriteLine("Insert is successful");

            string sqlread = "Select * from Filmler";
            db.ExecuteReader(connection, sqlread);
         
        }
    }
}
