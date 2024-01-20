using Ado.netWithInterface.Abstract;
using Ado.netWithInterface.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.netWithInterface.Concrete
{
    public class DataBase : BaseDataBase, IDataBase
    {
        Shipper shipper = new Shipper();
        Shippers shipperstbl = new Shippers();

        public SqlCommand SqlConnection(string constr)
        {
            connection = new SqlConnection(constr);
            return connection.CreateCommand();
        }

        public void ExecuteNonQuery(string sql)
        {
            connection.Open();
            Command.CommandText = sql;
            Command.ExecuteNonQuery();
            connection.Close();
        }

        public void ExecuteReader(string sql)
        {
            connection.Open();
            Command.CommandText = sql;
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                shipper.ShipperID = int.Parse(Reader["ShipperID"].ToString());
                shipper.CampanyName = Reader["CompanyName"].ToString();
                shipper.Phone = Reader["Phone"].ToString();
                shipperstbl.shippers.Add(shipper);
            }
            connection.Close();
        }

    }
}
