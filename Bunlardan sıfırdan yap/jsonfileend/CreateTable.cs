using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsonfileend
{
    public class CreateTable
    {
        public void createtab()
        {
            string createcumle = $@"CREATE TABLE [dbo].[Customers](
														[CustomerID] [nchar](50) NOT NULL,
														[CompanyName] [nvarchar](40) NOT NULL,
														[ContactName] [nvarchar](30) NULL,
														[ContactTitle] [nvarchar](30) NULL,
														[Address] [nvarchar](60) NULL,
														[City] [nvarchar](15) NULL,
														[PostalCode] [nvarchar](10) NULL,
														[Country] [nvarchar](15) NULL,
														[Phone] [nvarchar](24) NULL,
														[Fax] [nvarchar](24) NULL,
													 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
													(
														[CustomerID] ASC
													))";


			databaseconnection db = new databaseconnection();
			var kop = db.dbcon();
			SqlCommand komut = new SqlCommand(createcumle, kop);
			komut.ExecuteNonQuery();
			kop.Close();
		}
    }
}
