using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace jsonfileend
{
    public class databaseconnection
    {
        public SqlConnection dbcon()
        {
            string constr = $@"Data Source=.;Initial Catalog=kutuphane;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;";
            SqlConnection kop = new SqlConnection(constr);
            kop.Open();
            return kop;
            
        }

        

    }
}
