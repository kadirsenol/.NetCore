using Ado.netDataBaseManager.Concrete;
using Ado.netDataBaseManager.Model;
using System.Data.SqlClient;

namespace Ado.netDataBaseManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string constr = $@"Server=.;Database=Northwind;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(constr);
            Database db = new Database(connection);
            string sqlinsert = $@"INSERT INTO [dbo].[Shippers]
                                             ([CompanyName]
                                             ,[Phone])
                                       VALUES
                                             ('MNG'
                                             ,'0216 444 00 11')";
            db.Execute(sqlinsert);
            Console.WriteLine("Insert is successful");

            string sqlread = "Select * from shippers";
           db.reader= db.ExecuteRead(sqlread);
            
            Shippers shippers = new Shippers();//Prop kısmında list instance alındı.
            while (db.reader.Read())
            {
                Shipper shipper = new Shipper(); //nesneyi her seferinde yeniden instancesi alınması gerekli.
                shipper.ShipperID=int.Parse(db.reader["ShipperID"].ToString());
                shipper.CampanyName=db.reader["CompanyName"].ToString();
                shipper.Phone=db.reader["Phone"].ToString();
                shippers.shippers.Add(shipper);
            }
            
            Console.WriteLine(shippers.shippers[1].Phone);
        }
    }
}
