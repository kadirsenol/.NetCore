using Dapper.Contrib.Extensions;
using Dapper.Contrib_ORM_ObjectRelationalMapping_.Models;
using System.Data.SqlClient;

namespace Dapper.Contrib_ORM_ObjectRelationalMapping_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection(@$"Server=.;Database=SinemaOtomasyon;Trusted_Connection=True;");
            Film film = new Film()
            {
                FilmAdi = "Yesil Yol",
                Aciklama = "Dostluk sadakat serüveni",
                Sure = 120
            };
            connection.Insert<Film>(film);//connection.update,delete..
            Console.WriteLine("Insert is successful!");

            Filmler films = new Filmler();
            films.filmler=connection.GetAll<Film>().ToList();
            Console.WriteLine("Reading is successful!");

        }
    }
}
