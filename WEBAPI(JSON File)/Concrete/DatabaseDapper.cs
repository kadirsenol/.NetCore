using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEBAPI_JSON_File_.Abstract;
using WEBAPI_JSON_File_.Concrete.Jsonfile;

namespace WEBAPI_JSON_File_.Concrete
{
    public class DatabaseDapper : IDatabaseDapper
    {
        public void createtable(IDbConnection connection)
        {
            try
            {
                connection.Execute($@"create table [dbo].[Customers](
                                                        [id][nvarchar](50) not null,
                                                    	[compaNyname][nvarchar](40)  null,
                                                    	[contactName][nvarchar](30) null,
                                                    	[contactTitle][nvarchar](30) null,
                                                    	[address][nvarchar](60) null,
                                                    	[city][nvarchar](15) null,
                                                    	[postalCode][nvarchar](10) null,
                                                    	[country][nvarchar](15) null,
                                                    	[phone][nvarchar](24) null,
                                                    	[fax][nvarchar](24) null,
                                                         CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
                                                        (
                                                        	[id] ASC
                                                        ))");
                Console.WriteLine("Tablo oluşturuldu !");
            }
            catch (Exception ex)
            {
                throw;
                Console.WriteLine(ex.Message);
            }
            
        }

        public void insertdatabase(IDbConnection connection, Customers customers)
        {
            try
            {
                foreach (Customer item in customers.results)
                {
                    if (item.companyName.Contains("'"))
                    {
                       item.companyName= item.companyName.Split('\'')[0].ToString();
                    }
                    if (item.address.Contains("'"))
                    {
                        item.address = item.address.Split('\'')[0].ToString();
                    }
                    connection.Execute($@"INSERT INTO [dbo].[Customers]
                                                               ([id]
                                                               ,[companyName]
                                                               ,[contactName]
                                                               ,[contactTitle]
                                                               ,[address]
                                                               ,[city]
                                                               ,[postalCode]
                                                               ,[country]
                                                               ,[phone]
                                                               ,[fax])
                                                         VALUES
                                                               ('{item.id}'
                                                               ,'{item.companyName}'
                                                               ,'{item.contactName}'
                                                               ,'{item.contactTitle}'
                                                               ,'{item.address}'
                                                               ,'{item.city}'
                                                               ,'{item.postalCode}'
                                                               ,'{item.country}'
                                                               ,'{item.phone}'
                                                               ,'{item.fax}')");
                }
                Console.WriteLine("Veriler veritabanına aktarıldı. !");

            }
            catch (Exception ex)
            {
                throw;
                Console.WriteLine(ex.Message);
            }
        }
    }
}
