using Ado.netWithInterface.Concrete;

namespace Ado.netWithInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string sqlrdr = "Select * from Shippers";
            string constr = "Server=.;Database=Northwind;Trusted_Connection=True;";
            DataBase db = new DataBase();
            db.Command = db.SqlConnection(constr);
            db.ExecuteReader(sqlrdr);

            #region CRUD islemler icin.
            //string sqlCRUD = "";
            //db.ExecuteNonQuery(sqlCRUD); 
            #endregion
        
            Console.WriteLine("Veri Aktarimi Basariyla Gerceklesmistir.");
        }
    }
}
