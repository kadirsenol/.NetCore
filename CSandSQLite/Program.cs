using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace CSandSQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            serverconnection();
        }
        public static void serverconnection()
        {
            //  string constr= "data source=C:\\Users\\kdrsn\\source\\repos\\SQLite\\northwind.db";
            SQLiteConnection kop = new SQLiteConnection();
            kop.ConnectionString = "data source=C:\\Users\\kdrsn\\source\\repos\\SQLite\\northwind.db";
            kop.Open();

            komutolusturma(kop);
        }

        public static void komutolusturma(SQLiteConnection kop)
        {
            SQLiteCommand komut = new SQLiteCommand(kop);

            komut.CommandText = SqlTabloOlusturCumleOlustur(); ;
            execute(komut);

            for (int i = 0; i < SqlInsertCumleOlustur().Count; i++)
            {
                komut.CommandText = SqlInsertCumleOlustur()[i];
                execute(komut);
                if (i == ((SqlInsertCumleOlustur().Count) - 1))
                {
                    kop.Close();
                }
            }

        }

        public static void execute(SQLiteCommand komut)
        {
            komut.ExecuteNonQuery();

        }

        public static string SqlTabloOlusturCumleOlustur()
        {
            string sqltablocumle = $@"CREATE TABLE  [Filmler] (
                                                  [ID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
                                                , [FilmAdi] text NOT NULL
                                                , [Aciklama] text NULL
                                                , [Sure] INTEGER NOT NULL
                                                   );";


            return sqltablocumle;
        }
        public static List<string> SqlInsertCumleOlustur()
        {
            List<string> list = new List<string>();
            string sqlinsertcumle = "";
            var topsatir = File.ReadAllLines("Filmler.csv");
            bool sutuniptal = false;

            foreach (var satir in topsatir)
            {
                if (sutuniptal == false)
                {
                    sutuniptal = true;
                    continue;
                }
                else
                {
                    try
                    {
                        var kelime = satir.Split(';');
                        sqlinsertcumle = $@"INSERT INTO Filmler
                                 (FilmAdi
                                 ,Aciklama
                                 ,Sure)
                           VALUES
                                  ('{kelime[1]}',
                                   '{kelime[2]}'
                                   ,{int.Parse(kelime[3])});";
                        list.Add(sqlinsertcumle);

                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("Hata:" + ex.Message);
                    }

                }
            }
            return list;
        }

    }
}