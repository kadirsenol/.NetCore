using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsonfileend
{
    public class Insertdb
    {
        public void insertmet(List<customer> results)
        {
            List<string> insertcumlist = new List<string>();

            foreach (var customer in results)
            {
                if (customer.companyName.Contains('\''))
                {
                    customer.companyName = "null";
                }
                else if (customer.address== "67, avenue de l'Europe")
                {
                    customer.address = "a";
                }
                string insertcumle = $@"INSERT INTO [dbo].[Customers]
                                                         ([CustomerID]
                                                         ,[CompanyName]
                                                         ,[ContactName]
                                                         ,[ContactTitle]
                                                         ,[Address]
                                                         ,[City]
                                                         ,[PostalCode]
                                                         ,[Country]
                                                         ,[Phone]
                                                         ,[Fax])
                                                   VALUES
                                                         ('{customer.id}'
                                                         ,'{customer.companyName}'
                                                         ,'{customer.contactName}'
                                                         ,'{customer.contactTitle}'
                                                         ,'{12}'
                                                         ,'{customer.city}'
                                                         ,'{customer.postalCode}'
                                                         ,'{customer.country}'
                                                         ,'{customer.phone}'
                                                         ,'{customer.fax}')";
                insertcumlist.Add(insertcumle);
            }   
            databaseconnection db = new databaseconnection();
            var kop = db.dbcon();
            foreach (var sql in insertcumlist)
            {
                SqlCommand komut = new SqlCommand(sql,kop);
                komut.ExecuteNonQuery();
            }
            kop.Close();
            
        }
    }
}
