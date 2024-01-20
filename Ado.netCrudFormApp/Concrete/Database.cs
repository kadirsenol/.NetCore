
using Ado.netCrudFormApp.Abstract;
using Ado.netCrudFormApp.DataBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.netCrudFormApp.Concrete
{
    public class Database : BaseDataBase, IDataBase
    {
        public void ExecuteNonQuary(SqlCommand command)
        {
            command.ExecuteNonQuery();
        }

        public Personeller ExecuteReader(SqlCommand command)
        {
            Personeller personeller1 = new Personeller();
            personeller1.personeller = new List<Personel>();
           
          reader=  command.ExecuteReader();
            
            while (reader.Read())
            {
                Personel personel = new Personel();
                personel.Id = int.Parse(reader["Id"].ToString());
                personel.Ad = reader["Ad"].ToString();
                personel.Soyad = reader["Soyad"].ToString();
                personel.Departman = reader["Departman"].ToString();
                personel.bolgesi = (Bolge)Enum.Parse(typeof(Bolge), reader["bolgesi"].ToString());
                personeller1.personeller.Add(personel);
            }
            
            
            return personeller1;
                
        }

        public void sqlConnection(string constr)
        {
            Sqlconnection = new SqlConnection(constr);
            Sqlcommand= Sqlconnection.CreateCommand();
          
        }
    }
}
